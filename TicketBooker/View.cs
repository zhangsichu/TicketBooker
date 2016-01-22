using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketBooker
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                Helper.LoadTaskForm.ApplicationNotifyIcon.Visible = true;
                e.Cancel = true;
            }
        }

        private void tmrRefreshTask_Tick(object sender, System.EventArgs e)
        {
            this.dgvViewTask.Rows.Clear();
            var list = Core.Helper.TaskList;
            
            int index = 0;
            foreach (var taskPair in list)
            {
                var taskTime = taskPair.Value.Task.IsImmediatelyTask ? string.Empty : taskPair.Value.Task.GetTaskStartTime().ToString("HH:mm:ss");

                index++;
                if(!taskPair.Value.Task.IsStarted)
                {
                    //Task is not start.
                    this.dgvViewTask.Rows.Add(index, taskPair.Value.Task.TaskName,
                                              TicketBooker.Properties.Resources.TaskWaiting, taskTime);
                }
                else
                {
                    if(taskPair.Value.Task.IsFinished)
                    {
                        //Task is finished.
                        var status = TicketBooker.Properties.Resources.TaskError;
                        var name = taskPair.Value.Task.TaskName;

                        if (taskPair.Value.TaskResult != null && taskPair.Value.TaskResult.IsSucceed)
                        {
                            status = TicketBooker.Properties.Resources.TaskOk;
                            name += "-" + taskPair.Value.TaskResult.Code;
                        }

                        this.dgvViewTask.Rows.Add(index, name, status, taskTime,
                                                  taskPair.Value.Task.RealStartTime.ToString("HH:mm:ss"),
                                                  taskPair.Value.Task.RealEndTime.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        //Task is not finished.
                        this.dgvViewTask.Rows.Add(index, taskPair.Value.Task.TaskName,
                                                  TicketBooker.Properties.Resources.TaskWorking, taskTime,
                                                  taskPair.Value.Task.RealStartTime.ToString("HH:mm:ss"));
                    }
                }
            }
        }
    }
}
