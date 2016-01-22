using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TicketBooker.Core
{
    public class TaskPair
    {
        private ITask task;
        private TaskResult taskResult;

        public TaskPair(ITask task)
        {
            this.task = task;
        }

        public ITask Task
        {
            get { return task; }
        }

        public TaskResult TaskResult
        {
            get { return taskResult; }
            internal set { taskResult = value; }
        }
    }

    public static class Helper
    {
        #region Log
        private static object syncObject = new object();
        private static Encoding DefaultEncoding = new UTF8Encoding();
        private static string BuildLogFileName()
        {
            return DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff") + ".txt";
        }
        private static void SaveLog(Exception exception)
        {
            lock (syncObject)
            {
                using (StreamWriter writer = new StreamWriter(BuildLogFileName(), false, DefaultEncoding))
                {
                    writer.Write(exception.Message);
                    writer.Close();
                }
            }
        }
        private static void SaveLog(string message)
        {
            lock (syncObject)
            {
                using (StreamWriter writer = new StreamWriter(BuildLogFileName(), false, DefaultEncoding))
                {
                    writer.Write(message);
                    writer.Close();
                }
            }
        }
        #endregion

        #region Constructor
        static Helper()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            SaveLog(e.Exception);
        }
        #endregion

        #region Load Setting Form
        private const string SettingFormName = "Setting";
        public static Form TryToLoadTaskSettingForm(string taskFile)
        {
            try
            {
                var fileInfo = new FileInfo(taskFile);
                if (!fileInfo.Exists)
                    return null;

                return Activator.CreateInstanceFrom(
                    taskFile,
                    fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length + 1) + SettingFormName).Unwrap() as Form;
            }
            catch(Exception exception)
            {
                SaveLog(exception);
                return null;
            }
        }
        #endregion

        #region Run A Task
        public static void StartTask(ITask task)
        {
            var queuedOne = false;
            do
            {
                queuedOne = ThreadPool.QueueUserWorkItem(new WaitCallback(RunTask), task);
                if(!queuedOne)
                    Thread.Sleep(500);
            }
            while (!queuedOne);
        }

        private static void RunTask(object state)
        {
            ITask task = state as ITask;

            task.IsStarted = true;
            task.RealStartTime = DateTime.Now;
            try
            {
                //set the request.
                HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(task.GetRequestUrl());
                request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Reload);
                task.PrepareTaskRequest(request);

                //do the request
                WebResponse response = request.GetResponse();
                var taskResult = task.GetResult(response);
                SetTaskResult(task, taskResult);
                SaveLog(taskResult.Message);
            }
            catch(Exception exception)
            {
                SaveLog(exception);
            }
            finally
            {
                task.RealEndTime = DateTime.Now;
                task.IsFinished = true;
            }
        }

        public static TaskResult RunTask(ITask task)
        {
            task.IsStarted = true;
            task.RealStartTime = DateTime.Now;
            try
            {
                //set the request.
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(task.GetRequestUrl());
                request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Reload);
                task.PrepareTaskRequest(request);

                //do the request
                WebResponse response = request.GetResponse();
                var taskResult = task.GetResult(response);
                SaveLog(taskResult.Message);
                return taskResult;
            }
            catch (Exception exception)
            {
               SaveLog(exception);
               throw exception;
            }
            finally
            {
                task.RealEndTime = DateTime.Now;
                task.IsFinished = true;
            }
        }
        #endregion

        #region Task List
        private static Dictionary<Guid, TaskPair> taskList = new Dictionary<Guid, TaskPair>();
        public static Dictionary<Guid, TaskPair> TaskList
        {
            get { return taskList; }
        }

        private static void SetTaskResult(ITask task, TaskResult taskResult)
        {
            taskList[task.TaskID].TaskResult = taskResult;
        }
        public static void PushTask(ITask task)
        {
            taskList.Add(task.TaskID, new TaskPair(task));
        }
        #endregion
    }
}
