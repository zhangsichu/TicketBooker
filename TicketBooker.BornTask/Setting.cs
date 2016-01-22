using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketBooker.Core;

namespace TicketBooker.BornTask
{
    public partial class Setting : Form
    {
        private class TaskWorkInfo
        {
            public BornTask Task { get; set; }
            public TaskResult TaskResult { get; set; }
            public TabPage TabPage { get; set; }
        }

        public Setting()
        {
            InitializeComponent();
            InitializeSetting();
        }

        private void InitializeSetting()
        {
            BormTaskSetting setting = Helper.LoadBormTaskSetting();
            this.cbxDoctorName.DataSource = setting.DoctorList;
            this.cbxDoctorName.DisplayMember = "Name";
            this.cbxDoctorName.ValueMember = "Code";

            this.cbxWantPeriod.DataSource = setting.RegisterDateTimeList;
            this.cbxWantPeriod.DisplayMember = "RegisterDateTypeName";
            this.cbxWantPeriod.ValueMember = "RegisterDateTypeCode";

            this.chkUserInfo.DataSource = setting.PersonList;
            this.chkUserInfo.DisplayMember = "Memo";
            this.chkUserInfo.ValueMember = "ID";
            this.dtpWantDate.Value = DateTime.Now.AddDays(1);
            this.dtpTaskTime.Value = DateTime.Now.AddMinutes(3);
        }

        private void btnPushTask_Click(object sender, EventArgs e)
        {
            var requestRegisterData = CreateRequestRegisterData();
            requestRegisterData.IsImmediatelyTask = this.cbxRunImmediately.Checked;
            requestRegisterData.TaskTime = this.dtpTaskTime.Value;

            foreach (var item in this.chkUserInfo.CheckedItems)
            {
                Core.Helper.PushTask(new BornTask(requestRegisterData, item as Person));
            }
        }

        private void cbxWantPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = this.cbxWantPeriod.SelectedItem as RegisterDateTime;
            if(selected != null)
            {
                this.cbxWantTime.DataSource = selected.DateTimeItemList;
                this.cbxWantTime.DisplayMember = "Name";
                this.cbxWantTime.ValueMember = "Code";
            }
        }

        private void btnBuildUrl_Click(object sender, EventArgs e)
        {
            if(this.chkUserInfo.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a person to register!", "Born Task Setting Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                this.btnPushTask.Enabled = false;
                this.btnRunTask.Enabled = false;
                return;
            }

            this.btnPushTask.Enabled = true;
            this.btnRunTask.Enabled = true;
            this.tbxRequestUrl.Text = BornTask.BuildTestUrl(CreateRequestRegisterData());
        }

        private RequestRegisterData CreateRequestRegisterData()
        {
            var result = new RequestRegisterData
                             {
                                 DoctorCode = this.cbxDoctorName.SelectedValue.ToString(),
                                 RegisterDateTypeCode = this.cbxWantPeriod.SelectedValue.ToString(),
                                 RegisterDateTimeCode = this.cbxWantTime.SelectedValue.ToString(),
                                 RegisterDate = this.dtpWantDate.Value,
                                 IsImmediatelyTask = this.cbxRunImmediately.Checked,
                                 TaskTime = this.dtpTaskTime.Value
                             };
            return result;
        }

        private void btnRunTask_Click(object sender, EventArgs e)
        {
            foreach (var item in this.chkUserInfo.CheckedItems)
            {
                var task = new BornTask(CreateRequestRegisterData(), item as Person);
                TabPage tabPage = new TabPage();
                tabPage.Text = "working...";
                RichTextBox infoTextBox = new RichTextBox()
                {
                    Text = task.TaskName + "working...",
                    Font = Control.DefaultFont,
                    Multiline = true,
                    WordWrap = false,
                    Dock = DockStyle.Fill
                };
                tabPage.Controls.Add(infoTextBox);
                this.tabResult.TabPages.Add(tabPage);
                Application.DoEvents();

                BackgroundWorker taskWorker = new BackgroundWorker();
                taskWorker.DoWork += new DoWorkEventHandler(taskWorker_DoWork);
                taskWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(taskWorker_RunWorkerCompleted);
                taskWorker.RunWorkerAsync(new TaskWorkInfo
                                              {
                                                  Task = task,
                                                  TabPage = tabPage
                                              });
            }
        }

        void taskWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TaskWorkInfo result = e.Result as TaskWorkInfo;
            var text = result.TaskResult.IsSucceed ? "Succeed:" + result.TaskResult.Code : "Failed" + "\r\n";
            result.TabPage.Text = text;
            result.TabPage.Controls[0].Text = result.TaskResult.Message;
        }

        void taskWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            TaskWorkInfo taskInfo = e.Argument as TaskWorkInfo;
            TaskResult result = null;
            try
            {
                result = Core.Helper.RunTask(taskInfo.Task);
            }
            catch(Exception exception)
            {
                result = new TaskResult
                             {
                                 IsSucceed = false,
                                 Message = exception.Message
                             };
            }

            taskInfo.TaskResult = result;
            e.Result = taskInfo;
        }

        void cbxRunImmediately_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpTaskTime.Enabled = !cbxRunImmediately.Checked;
        }

        private void tabResult_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Middle)
            {
                int tabIndex = -1;
                for (int i = 0; i < this.tabResult.TabCount; i++)
                {
                    Rectangle rectangle = this.tabResult.GetTabRect(i);
                    if (rectangle.Contains(e.Location))
                    {
                        tabIndex = i; // get the tab.
                        break;
                    }
                }

                if (tabIndex >= 0)
                    this.tabResult.TabPages.RemoveAt(tabIndex);
            }
        }
    }
}
