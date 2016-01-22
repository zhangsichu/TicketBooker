using System.Windows.Forms;

namespace TicketBooker
{
    partial class Load
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
            this.components = new System.ComponentModel.Container();
            this.resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.dgvLoadedTasks = new System.Windows.Forms.DataGridView();
            this.dcsLoadedTasks = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBrowserTask = new System.Windows.Forms.Button();
            this.txtTaskLocation = new System.Windows.Forms.TextBox();
            this.lblTaskLocation = new System.Windows.Forms.Label();
            this.ofdTaskLocation = new System.Windows.Forms.OpenFileDialog();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskAvailable = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaskAddedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLoadTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFirst = new System.Windows.Forms.ToolStripSeparator();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSecond = new System.Windows.Forms.ToolStripSeparator();
            this.tsmLoadedTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tssThird = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrPushTask = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(dgvLoadedTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoadedTasks
            // 
            dgvLoadedTasks.AllowUserToAddRows = false;
            dgvLoadedTasks.AllowUserToDeleteRows = false;
            dgvLoadedTasks.AllowUserToResizeColumns = false;
            dgvLoadedTasks.AllowUserToResizeRows = false;
            dgvLoadedTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoadedTasks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvLoadedTasks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dgvLoadedTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dcsLoadedTasks.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dcsLoadedTasks.BackColor = System.Drawing.SystemColors.Control;
            dcsLoadedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dcsLoadedTasks.ForeColor = System.Drawing.SystemColors.WindowText;
            dcsLoadedTasks.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dcsLoadedTasks.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dcsLoadedTasks.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvLoadedTasks.ColumnHeadersDefaultCellStyle = dcsLoadedTasks;
            dgvLoadedTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLoadedTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskAvailable,
            this.TaskAddedTime,
            this.TaskFile});
            dgvLoadedTasks.EnableHeadersVisualStyles = false;
            dgvLoadedTasks.Location = new System.Drawing.Point(15, 51);
            dgvLoadedTasks.MultiSelect = false;
            dgvLoadedTasks.Name = "dgvLoadedTasks";
            dgvLoadedTasks.ReadOnly = true;
            dgvLoadedTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgvLoadedTasks.RowHeadersVisible = false;
            dgvLoadedTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLoadedTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgvLoadedTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLoadedTasks.Size = new System.Drawing.Size(427, 256);
            dgvLoadedTasks.TabIndex = 20;
            // 
            // btnBrowserTask
            // 
            this.btnBrowserTask.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserTask.Image")));
            this.btnBrowserTask.Location = new System.Drawing.Point(388, 12);
            this.btnBrowserTask.Name = "btnBrowserTask";
            this.btnBrowserTask.Size = new System.Drawing.Size(24, 24);
            this.btnBrowserTask.TabIndex = 6;
            this.btnBrowserTask.Click += new System.EventHandler(this.btnBrowserTask_Click);
            // 
            // txtTaskLocation
            // 
            this.txtTaskLocation.Location = new System.Drawing.Point(111, 14);
            this.txtTaskLocation.Name = "txtTaskLocation";
            this.txtTaskLocation.ReadOnly = true;
            this.txtTaskLocation.Size = new System.Drawing.Size(271, 20);
            this.txtTaskLocation.TabIndex = 5;
            // 
            // lblTaskLocation
            // 
            this.lblTaskLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskLocation.Location = new System.Drawing.Point(12, 12);
            this.lblTaskLocation.Name = "lblTaskLocation";
            this.lblTaskLocation.Size = new System.Drawing.Size(93, 23);
            this.lblTaskLocation.TabIndex = 4;
            this.lblTaskLocation.Text = "Task Location:";
            this.lblTaskLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ofdTaskLocation
            // 
            this.ofdTaskLocation.Filter = "Task File (*.dll)|*.dll";
            this.ofdTaskLocation.RestoreDirectory = true;
            this.ofdTaskLocation.ShowReadOnly = true;
            this.ofdTaskLocation.SupportMultiDottedExtensions = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
            this.btnAddTask.Location = new System.Drawing.Point(418, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(24, 24);
            this.btnAddTask.TabIndex = 19;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "TaskName";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 180;
            // 
            // TaskAvailable
            // 
            this.TaskAvailable.HeaderText = "Available";
            this.TaskAvailable.Name = "TaskAvailable";
            this.TaskAvailable.ReadOnly = true;
            this.TaskAvailable.Width = 35;
            // 
            // TaskAddedTime
            // 
            this.TaskAddedTime.HeaderText = "Time";
            this.TaskAddedTime.Name = "TaskAddedTime";
            this.TaskAddedTime.ReadOnly = true;
            this.TaskAddedTime.Width = 45;
            // 
            // TaskFile
            // 
            this.TaskFile.HeaderText = "";
            this.TaskFile.Name = "TaskFile";
            this.TaskFile.ReadOnly = true;
            this.TaskFile.Visible = false;
            this.TaskFile.Width = 1;
            // 
            // ntiMain
            // 
            this.ntiMain.ContextMenuStrip = this.ctmMain;
            this.ntiMain.Text = "Ticket Booker";
            this.ntiMain.Icon = TicketBooker.Properties.Resources.Icon;
            // 
            // ctmMain
            // 
            this.ctmMain.AllowMerge = false;
            this.ctmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoadTask,
            this.tsmViewTask,
            this.tssFirst,
            this.tsmStart,
            this.tsmStop,
            this.tssSecond,
            this.tsmLoadedTask,
            this.tssThird,
            this.tsmExit});
            this.ctmMain.Name = "ctmMain";
            this.ctmMain.ShowImageMargin = false;
            this.ctmMain.Size = new System.Drawing.Size(128, 148);
            // 
            // tsmLoadTask
            // 
            this.tsmLoadTask.Name = "tsmLoadTask";
            this.tsmLoadTask.Size = new System.Drawing.Size(127, 22);
            this.tsmLoadTask.Text = "&Load Task";
            this.tsmLoadTask.Click += new System.EventHandler(tsmLoadTask_Click);
            // 
            // tsmViewTask
            // 
            this.tsmViewTask.Name = "tsmViewTask";
            this.tsmViewTask.Size = new System.Drawing.Size(127, 22);
            this.tsmViewTask.Text = "&View Task";
            this.tsmViewTask.Click += new System.EventHandler(tsmViewTask_Click);
            // 
            // tssFirst
            // 
            this.tssFirst.Name = "tssFirst";
            this.tssFirst.Size = new System.Drawing.Size(124, 6);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(127, 22);
            this.tsmStart.Text = "&Start";
            this.tsmStart.Click += new System.EventHandler(tsmStart_Click);
            // 
            // tsmStop
            // 
            this.tsmStop.Name = "tsmStop";
            this.tsmStop.Size = new System.Drawing.Size(127, 22);
            this.tsmStop.Text = "St&op";
            this.tsmStop.Enabled = false;
            this.tsmStop.Click += new System.EventHandler(tsmStop_Click);
            // 
            // tssSecond
            // 
            this.tssSecond.Name = "tssSecond";
            this.tssSecond.Size = new System.Drawing.Size(124, 6);
            // 
            // tsmLoadedTask
            // 
            this.tsmLoadedTask.Name = "tsmLoadedTask";
            this.tsmLoadedTask.Size = new System.Drawing.Size(127, 22);
            this.tsmLoadedTask.Text = "&Task(s)";
            this.tsmLoadedTask.Enabled = false;
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(127, 22);
            this.tsmExit.Text = "E&xit";
            this.tsmExit.Click += new System.EventHandler(tsmExit_Click);
            // 
            // tmrPushTask
            // 
            this.tmrPushTask.Interval = 900;
            this.tmrPushTask.Tick += new System.EventHandler(tmrPushTask_Tick);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 319);
            this.Controls.Add(dgvLoadedTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnBrowserTask);
            this.Controls.Add(this.txtTaskLocation);
            this.Controls.Add(this.lblTaskLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = TicketBooker.Properties.Resources.Icon;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Load";
            this.Text = "Load Task";
            this.FormClosing += new FormClosingEventHandler(Load_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(dgvLoadedTasks)).EndInit();
            this.ctmMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnBrowserTask;
        private System.Windows.Forms.TextBox txtTaskLocation;
        private System.Windows.Forms.Label lblTaskLocation;
        private System.Windows.Forms.OpenFileDialog ofdTaskLocation;
        private System.Windows.Forms.Button btnAddTask;

        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewImageColumn TaskAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskAddedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskFile;
        private System.Windows.Forms.DataGridView dgvLoadedTasks;
        private System.Windows.Forms.DataGridViewCellStyle dcsLoadedTasks;

        private NotifyIcon ntiMain;
        private ContextMenuStrip ctmMain;
        private ToolStripMenuItem tsmLoadTask;
        private ToolStripMenuItem tsmViewTask;
        private ToolStripSeparator tssFirst;
        private ToolStripMenuItem tsmStart;
        private ToolStripMenuItem tsmStop;
        private ToolStripSeparator tssSecond;
        private ToolStripMenuItem tsmLoadedTask;
        private ToolStripSeparator tssThird;
        private ToolStripMenuItem tsmExit;

        private System.Windows.Forms.Timer tmrPushTask;
        private System.ComponentModel.ComponentResourceManager resources;
    }
}

