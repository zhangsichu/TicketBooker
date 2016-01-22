using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketBooker.Core;

namespace TicketBooker
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        public NotifyIcon ApplicationNotifyIcon
        {
            get { return ntiMain; }
        }

        private void btnBrowserTask_Click(object sender, EventArgs e)
        {
            ofdTaskLocation.FileName = txtTaskLocation.Text;
            if (ofdTaskLocation.ShowDialog(this) == DialogResult.OK)
                txtTaskLocation.Text = ofdTaskLocation.FileName;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTaskLocation.Text))
            {
                MessageBox.Show("Please select a valid task!", "Task Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fileInfo = new FileInfo(txtTaskLocation.Text);
            if(!fileInfo.Exists)
            {
                MessageBox.Show("Invalid task file!", "Task Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in this.dgvLoadedTasks.Rows)
            {
                if (fileInfo.Name == (string)row.Cells[0].Value || fileInfo.FullName == (string)row.Cells[3].Value)
                {
                    MessageBox.Show("Task is added!", "Task Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            var setting = Core.Helper.TryToLoadTaskSettingForm(fileInfo.FullName);
            Image statusImage = null;

            if(setting != null)
            {
                Helper.TaskSettingList.Add(fileInfo.Name, setting);
                setting.FormClosing += new FormClosingEventHandler(setting_FormClosing);

                ToolStripMenuItem taskMenuItem = new ToolStripMenuItem();
                taskMenuItem.Name = fileInfo.Name;
                taskMenuItem.Text = fileInfo.Name;
                taskMenuItem.Click += new EventHandler(taskMenuItem_Click);
                this.tsmLoadedTask.DropDownItems.Add(taskMenuItem);
                this.tsmLoadedTask.Enabled = true;
                statusImage = TicketBooker.Properties.Resources.TaskOk;
            }
            else
            {
                statusImage = TicketBooker.Properties.Resources.TaskError;
            }

            this.dgvLoadedTasks.Rows.Add(fileInfo.Name, statusImage, DateTime.Now.ToString("HH:mm:ss"), fileInfo.FullName);
        }

        private void setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                (sender as Form).Hide();
                Helper.LoadTaskForm.ApplicationNotifyIcon.Visible = true;
                e.Cancel = true;
            }
        }

        private void taskMenuItem_Click(object sender, EventArgs e)
        {
            Helper.TaskSettingList[((ToolStripMenuItem)sender).Name].Show();
            Helper.LoadTaskForm.ApplicationNotifyIcon.Visible = false;
        }

        private void Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall
                || e.CloseReason == CloseReason.TaskManagerClosing
                || e.CloseReason == CloseReason.WindowsShutDown)

                return; // do nothing, close the window.

            if (e.CloseReason == CloseReason.UserClosing && this.dgvLoadedTasks.Rows.Count == 0)
                return; // do nothing, close the window.

            e.Cancel = true;
            this.Hide();
            ntiMain.Visible = true;
        }

        private void tsmStop_Click(object sender, System.EventArgs e)
        {
            Helper.TaskStarted = false;
            this.tsmStart.Enabled = true;
            this.tsmStop.Enabled = false;
            this.tmrPushTask.Stop();
            this.tmrPushTask.Enabled = false;
        }

        private void tsmStart_Click(object sender, System.EventArgs e)
        {
            Helper.TaskStarted = true;
            this.tsmStart.Enabled = false;
            this.tsmStop.Enabled = true;
            this.tmrPushTask.Enabled = true;
            this.tmrPushTask.Start();
        }

        private void tsmViewTask_Click(object sender, System.EventArgs e)
        {
            Helper.ViewTaskForm.Show();
            ntiMain.Visible = false;
        }
        
        private void tsmLoadTask_Click(object sender, System.EventArgs e)
        {
            Helper.LoadTaskForm.Show();
            ntiMain.Visible = false;
        }

        private void tsmExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void tmrPushTask_Tick(object sender, System.EventArgs e)
        {
            var list = Core.Helper.TaskList;
            foreach (var task in list)
            {
                var needStart = false;
                if(!task.Value.Task.IsStarted)
                {
                    if (task.Value.Task.IsImmediatelyTask)
                        needStart = true;
                    else
                    {
                        double time = task.Value.Task.GetTaskStartTime().Subtract(DateTime.Now).TotalSeconds;
                        if(time>=0 && time<= 1)
                            needStart = true;
                    }
                }
                if(needStart)
                {
                    Core.Helper.StartTask(task.Value.Task);
                }
            }
        }
    }
}
