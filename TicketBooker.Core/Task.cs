using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace TicketBooker.Core
{
    public class TaskResult
    {
        public bool IsSucceed { get; set; }
        public object Tag { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
    }

    public interface ITask
    {
        bool IsStarted { get; set; }
        bool IsFinished { get; set; }

        string GetRequestUrl();
        void PrepareTaskRequest(HttpWebRequest request);
        TaskResult GetResult(WebResponse response);

        bool IsImmediatelyTask { get; set; }
        DateTime GetTaskStartTime();

        DateTime RealStartTime { get; set; }
        DateTime RealEndTime { get; set; }

        string TaskName { get; }
        Guid TaskID { get; }
    }

    public abstract class BaseTask : ITask
    {

        public virtual bool IsStarted { get; set; }

        public virtual bool IsFinished { get; set; }

        public abstract string GetRequestUrl();

        public abstract void PrepareTaskRequest(HttpWebRequest request);

        public abstract TaskResult GetResult(WebResponse response);

        public virtual bool IsImmediatelyTask { get; set; }

        public virtual DateTime GetTaskStartTime()
        {
            return DateTime.Now;
        }

        public virtual DateTime RealStartTime { get; set; }

        public virtual DateTime RealEndTime { get; set; }

        public virtual string TaskName { get; set; }

        private Guid taskID = Guid.NewGuid();
        public virtual Guid TaskID { get { return taskID; } }
    }
}
