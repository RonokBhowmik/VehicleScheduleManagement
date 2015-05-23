namespace VehicleScheduleManagement.UI
{
    partial class DateBetweenSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.startMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.endMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.showDateBetweenScheduleButton = new System.Windows.Forms.Button();
            this.dateBetweenDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dateBetweenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Between";
            // 
            // startMonthCalendar
            // 
            this.startMonthCalendar.Location = new System.Drawing.Point(9, 58);
            this.startMonthCalendar.Name = "startMonthCalendar";
            this.startMonthCalendar.TabIndex = 1;
            // 
            // endMonthCalendar
            // 
            this.endMonthCalendar.Location = new System.Drawing.Point(308, 58);
            this.endMonthCalendar.Name = "endMonthCalendar";
            this.endMonthCalendar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "and";
            // 
            // showDateBetweenScheduleButton
            // 
            this.showDateBetweenScheduleButton.Location = new System.Drawing.Point(369, 232);
            this.showDateBetweenScheduleButton.Name = "showDateBetweenScheduleButton";
            this.showDateBetweenScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.showDateBetweenScheduleButton.TabIndex = 3;
            this.showDateBetweenScheduleButton.Text = "Show";
            this.showDateBetweenScheduleButton.UseVisualStyleBackColor = true;
            this.showDateBetweenScheduleButton.Click += new System.EventHandler(this.showDateBetweenScheduleButton_Click);
            // 
            // dateBetweenDataGridView
            // 
            this.dateBetweenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateBetweenDataGridView.Location = new System.Drawing.Point(12, 261);
            this.dateBetweenDataGridView.Name = "dateBetweenDataGridView";
            this.dateBetweenDataGridView.Size = new System.Drawing.Size(523, 230);
            this.dateBetweenDataGridView.TabIndex = 4;
            // 
            // DateBetweenSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 503);
            this.Controls.Add(this.dateBetweenDataGridView);
            this.Controls.Add(this.showDateBetweenScheduleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endMonthCalendar);
            this.Controls.Add(this.startMonthCalendar);
            this.Controls.Add(this.label1);
            this.Name = "DateBetweenSchedule";
            this.Text = "View Date Between Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dateBetweenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar startMonthCalendar;
        private System.Windows.Forms.MonthCalendar endMonthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showDateBetweenScheduleButton;
        private System.Windows.Forms.DataGridView dateBetweenDataGridView;
    }
}