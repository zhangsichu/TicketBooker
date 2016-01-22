using System.Windows.Forms;

namespace TicketBooker.BornTask
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxWantTime = new System.Windows.Forms.ComboBox();
            this.tbxRequestUrl = new System.Windows.Forms.TextBox();
            this.lblRequestUrl = new System.Windows.Forms.Label();
            this.chkUserInfo = new System.Windows.Forms.CheckedListBox();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.cbxWantPeriod = new System.Windows.Forms.ComboBox();
            this.dtpWantDate = new System.Windows.Forms.DateTimePicker();
            this.lblWantPeriod = new System.Windows.Forms.Label();
            this.lblWantDate = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.btnPushTask = new System.Windows.Forms.Button();
            this.gbxDoctorInfo = new System.Windows.Forms.GroupBox();
            this.cbxDoctorName = new System.Windows.Forms.ComboBox();
            this.gbxUserInfo = new System.Windows.Forms.GroupBox();
            this.cbxRunImmediately = new System.Windows.Forms.CheckBox();
            this.dtpTaskTime = new System.Windows.Forms.DateTimePicker();
            this.btnBuildUrl = new System.Windows.Forms.Button();
            this.gbxTaskSetting = new System.Windows.Forms.GroupBox();
            this.lblTaskTime = new System.Windows.Forms.Label();
            this.gbxDoctorInfo.SuspendLayout();
            this.gbxUserInfo.SuspendLayout();
            this.gbxTaskSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxWantTime
            // 
            this.cbxWantTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWantTime.FormattingEnabled = true;
            this.cbxWantTime.Location = new System.Drawing.Point(183, 59);
            this.cbxWantTime.Name = "cbxWantTime";
            this.cbxWantTime.Size = new System.Drawing.Size(160, 21);
            this.cbxWantTime.TabIndex = 37;
            // 
            // tbxRequestUrl
            // 
            this.tbxRequestUrl.Location = new System.Drawing.Point(92, 125);
            this.tbxRequestUrl.Name = "tbxRequestUrl";
            this.tbxRequestUrl.ReadOnly = true;
            this.tbxRequestUrl.Size = new System.Drawing.Size(608, 20);
            this.tbxRequestUrl.TabIndex = 32;
            // 
            // lblRequestUrl
            // 
            this.lblRequestUrl.AutoSize = true;
            this.lblRequestUrl.Location = new System.Drawing.Point(28, 128);
            this.lblRequestUrl.Name = "lblRequestUrl";
            this.lblRequestUrl.Size = new System.Drawing.Size(55, 13);
            this.lblRequestUrl.TabIndex = 31;
            this.lblRequestUrl.Text = "网络地址";
            // 
            // chkUserInfo
            // 
            this.chkUserInfo.FormattingEnabled = true;
            this.chkUserInfo.Location = new System.Drawing.Point(6, 19);
            this.chkUserInfo.Name = "chkUserInfo";
            this.chkUserInfo.Size = new System.Drawing.Size(438, 64);
            this.chkUserInfo.TabIndex = 30;
            // 
            // btnRunTask
            // 
            this.btnRunTask.BackColor = System.Drawing.Color.White;
            this.btnRunTask.Enabled = false;
            this.btnRunTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunTask.Location = new System.Drawing.Point(525, 162);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(311, 45);
            this.btnRunTask.TabIndex = 28;
            this.btnRunTask.Text = "立即抢票";
            this.btnRunTask.UseVisualStyleBackColor = false;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // cbxWantPeriod
            // 
            this.cbxWantPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWantPeriod.FormattingEnabled = true;
            this.cbxWantPeriod.Location = new System.Drawing.Point(69, 59);
            this.cbxWantPeriod.Name = "cbxWantPeriod";
            this.cbxWantPeriod.Size = new System.Drawing.Size(105, 21);
            this.cbxWantPeriod.TabIndex = 26;
            this.cbxWantPeriod.SelectedIndexChanged += new System.EventHandler(this.cbxWantPeriod_SelectedIndexChanged);
            // 
            // dtpWantDate
            // 
            this.dtpWantDate.CustomFormat = "yyyy-M-d";
            this.dtpWantDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWantDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWantDate.Location = new System.Drawing.Point(241, 26);
            this.dtpWantDate.Name = "dtpWantDate";
            this.dtpWantDate.Size = new System.Drawing.Size(102, 20);
            this.dtpWantDate.TabIndex = 25;
            // 
            // lblWantPeriod
            // 
            this.lblWantPeriod.AutoSize = true;
            this.lblWantPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWantPeriod.Location = new System.Drawing.Point(5, 62);
            this.lblWantPeriod.Name = "lblWantPeriod";
            this.lblWantPeriod.Size = new System.Drawing.Size(58, 13);
            this.lblWantPeriod.TabIndex = 23;
            this.lblWantPeriod.Text = "预约时段:";
            // 
            // lblWantDate
            // 
            this.lblWantDate.AutoSize = true;
            this.lblWantDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWantDate.Location = new System.Drawing.Point(180, 29);
            this.lblWantDate.Name = "lblWantDate";
            this.lblWantDate.Size = new System.Drawing.Size(58, 13);
            this.lblWantDate.TabIndex = 24;
            this.lblWantDate.Text = "预约日期:";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(6, 29);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(58, 13);
            this.lblDoctorName.TabIndex = 19;
            this.lblDoctorName.Text = "医生姓名:";
            // 
            // tabResult
            // 
            this.tabResult.Location = new System.Drawing.Point(23, 228);
            this.tabResult.Name = "tabResult";
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(813, 414);
            this.tabResult.TabIndex = 38;
            this.tabResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabResult_MouseDown);
            // 
            // btnPushTask
            // 
            this.btnPushTask.BackColor = System.Drawing.Color.White;
            this.btnPushTask.Enabled = false;
            this.btnPushTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPushTask.Location = new System.Drawing.Point(319, 16);
            this.btnPushTask.Name = "btnPushTask";
            this.btnPushTask.Size = new System.Drawing.Size(171, 31);
            this.btnPushTask.TabIndex = 39;
            this.btnPushTask.Text = "提交任务";
            this.btnPushTask.UseVisualStyleBackColor = false;
            this.btnPushTask.Click += new System.EventHandler(this.btnPushTask_Click);
            // 
            // gbxDoctorInfo
            // 
            this.gbxDoctorInfo.Controls.Add(this.cbxDoctorName);
            this.gbxDoctorInfo.Controls.Add(this.dtpWantDate);
            this.gbxDoctorInfo.Controls.Add(this.lblDoctorName);
            this.gbxDoctorInfo.Controls.Add(this.cbxWantTime);
            this.gbxDoctorInfo.Controls.Add(this.lblWantDate);
            this.gbxDoctorInfo.Controls.Add(this.lblWantPeriod);
            this.gbxDoctorInfo.Controls.Add(this.cbxWantPeriod);
            this.gbxDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDoctorInfo.Location = new System.Drawing.Point(23, 15);
            this.gbxDoctorInfo.Name = "gbxDoctorInfo";
            this.gbxDoctorInfo.Size = new System.Drawing.Size(357, 94);
            this.gbxDoctorInfo.TabIndex = 40;
            this.gbxDoctorInfo.TabStop = false;
            this.gbxDoctorInfo.Text = "预约信息:";
            // 
            // cbxDoctorName
            // 
            this.cbxDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoctorName.FormattingEnabled = true;
            this.cbxDoctorName.Location = new System.Drawing.Point(69, 26);
            this.cbxDoctorName.Name = "cbxDoctorName";
            this.cbxDoctorName.Size = new System.Drawing.Size(105, 21);
            this.cbxDoctorName.TabIndex = 38;
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Controls.Add(this.chkUserInfo);
            this.gbxUserInfo.Location = new System.Drawing.Point(386, 15);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Size = new System.Drawing.Size(450, 94);
            this.gbxUserInfo.TabIndex = 41;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "用户信息:";
            // 
            // cbxRunImmediately
            // 
            this.cbxRunImmediately.AutoSize = true;
            this.cbxRunImmediately.Checked = true;
            this.cbxRunImmediately.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRunImmediately.Location = new System.Drawing.Point(10, 25);
            this.cbxRunImmediately.Name = "cbxRunImmediately";
            this.cbxRunImmediately.Size = new System.Drawing.Size(74, 17);
            this.cbxRunImmediately.TabIndex = 42;
            this.cbxRunImmediately.Text = "立即执行";
            this.cbxRunImmediately.UseVisualStyleBackColor = true;
            this.cbxRunImmediately.CheckedChanged += new System.EventHandler(this.cbxRunImmediately_CheckedChanged);
            // 
            // dtpTaskTime
            // 
            this.dtpTaskTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtpTaskTime.Enabled = false;
            this.dtpTaskTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskTime.Location = new System.Drawing.Point(149, 22);
            this.dtpTaskTime.Name = "dtpTaskTime";
            this.dtpTaskTime.ShowUpDown = true;
            this.dtpTaskTime.Size = new System.Drawing.Size(141, 20);
            this.dtpTaskTime.TabIndex = 43;
            // 
            // btnBuildUrl
            // 
            this.btnBuildUrl.BackColor = System.Drawing.Color.White;
            this.btnBuildUrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildUrl.Location = new System.Drawing.Point(706, 120);
            this.btnBuildUrl.Name = "btnBuildUrl";
            this.btnBuildUrl.Size = new System.Drawing.Size(132, 31);
            this.btnBuildUrl.TabIndex = 45;
            this.btnBuildUrl.Text = "生成请求数据";
            this.btnBuildUrl.UseVisualStyleBackColor = false;
            this.btnBuildUrl.Click += new System.EventHandler(this.btnBuildUrl_Click);
            // 
            // gbxTaskSetting
            // 
            this.gbxTaskSetting.Controls.Add(this.lblTaskTime);
            this.gbxTaskSetting.Controls.Add(this.cbxRunImmediately);
            this.gbxTaskSetting.Controls.Add(this.dtpTaskTime);
            this.gbxTaskSetting.Controls.Add(this.btnPushTask);
            this.gbxTaskSetting.Location = new System.Drawing.Point(23, 153);
            this.gbxTaskSetting.Name = "gbxTaskSetting";
            this.gbxTaskSetting.Size = new System.Drawing.Size(496, 57);
            this.gbxTaskSetting.TabIndex = 46;
            this.gbxTaskSetting.TabStop = false;
            this.gbxTaskSetting.Text = "任务设置:";
            // 
            // lblTaskTime
            // 
            this.lblTaskTime.AutoSize = true;
            this.lblTaskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTime.Location = new System.Drawing.Point(85, 26);
            this.lblTaskTime.Name = "lblTaskTime";
            this.lblTaskTime.Size = new System.Drawing.Size(58, 13);
            this.lblTaskTime.TabIndex = 44;
            this.lblTaskTime.Text = "计划时间:";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 656);
            this.Controls.Add(this.gbxTaskSetting);
            this.Controls.Add(this.btnBuildUrl);
            this.Controls.Add(this.gbxUserInfo);
            this.Controls.Add(this.gbxDoctorInfo);
            this.Controls.Add(this.tabResult);
            this.Controls.Add(this.tbxRequestUrl);
            this.Controls.Add(this.lblRequestUrl);
            this.Controls.Add(this.btnRunTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::TicketBooker.BornTask.Properties.Resources.Icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketBooker.BornTask.Setting";
            this.gbxDoctorInfo.ResumeLayout(false);
            this.gbxDoctorInfo.PerformLayout();
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxTaskSetting.ResumeLayout(false);
            this.gbxTaskSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxWantTime;
        private TextBox tbxRequestUrl;
        private Label lblRequestUrl;
        private CheckedListBox chkUserInfo;
        private Button btnRunTask;
        private ComboBox cbxWantPeriod;
        private DateTimePicker dtpWantDate;
        private Label lblWantPeriod;
        private Label lblWantDate;
        private Label lblDoctorName;
        private TabControl tabResult;
        private Button btnPushTask;
        private GroupBox gbxDoctorInfo;
        private GroupBox gbxUserInfo;
        private CheckBox cbxRunImmediately;
        private DateTimePicker dtpTaskTime;
        private Button btnBuildUrl;
        private GroupBox gbxTaskSetting;
        private Label lblTaskTime;
        private ComboBox cbxDoctorName;

    }
}

