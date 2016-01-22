using System.Windows.Forms;

namespace TicketBooker
{
    partial class View
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
            this.dcsViewTask = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvViewTask = new System.Windows.Forms.DataGridView();
            this.tmrRefreshTask = new System.Windows.Forms.Timer(this.components);
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.TaskTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewTask
            // 
            this.dgvViewTask.AllowUserToAddRows = false;
            this.dgvViewTask.AllowUserToDeleteRows = false;
            this.dgvViewTask.AllowUserToResizeColumns = false;
            this.dgvViewTask.AllowUserToResizeRows = false;
            this.dgvViewTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewTask.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvViewTask.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvViewTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dcsViewTask.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dcsViewTask.BackColor = System.Drawing.SystemColors.Control;
            this.dcsViewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dcsViewTask.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dcsViewTask.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dcsViewTask.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dcsViewTask.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewTask.ColumnHeadersDefaultCellStyle = dcsViewTask;
            this.dgvViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.TaskName,
            this.Status,
            this.TaskTime,
            this.StartTime,
            this.EndTime});
            this.dgvViewTask.EnableHeadersVisualStyles = false;
            this.dgvViewTask.Location = new System.Drawing.Point(12, 12);
            this.dgvViewTask.MultiSelect = false;
            this.dgvViewTask.Name = "dgvViewTask";
            this.dgvViewTask.ReadOnly = true;
            this.dgvViewTask.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvViewTask.RowHeadersVisible = false;
            this.dgvViewTask.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvViewTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvViewTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewTask.Size = new System.Drawing.Size(691, 480);
            this.dgvViewTask.TabIndex = 0;
            // 
            // tmrRefreshTask
            // 
            this.tmrRefreshTask.Enabled = true;
            this.tmrRefreshTask.Interval = 900;
            this.tmrRefreshTask.Tick += new System.EventHandler(this.tmrRefreshTask_Tick);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 320;
            this.TaskName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.TaskTime.Width = 40;
            // 
            // TaskTime
            // 
            this.TaskTime.HeaderText = "Task Time";
            this.TaskTime.Name = "TaskTime";
            this.TaskTime.ReadOnly = true;
            this.TaskTime.Width = 60;
            this.TaskTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 60;
            this.StartTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 70;
            this.EndTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 504);
            this.Controls.Add(this.dgvViewTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::TicketBooker.Properties.Resources.Icon;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTask)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DataGridView dgvViewTask;
        private System.Windows.Forms.DataGridViewCellStyle dcsViewTask;
        private System.Windows.Forms.Timer tmrRefreshTask;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewImageColumn Status;
        private DataGridViewTextBoxColumn TaskTime;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
    }
}