namespace VehicleScheduleManagement.UI
{
    partial class VehicleScheduleUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.selectVehicleComboBox = new System.Windows.Forms.ComboBox();
            this.selectDateCalender = new System.Windows.Forms.MonthCalendar();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.bookedByTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Booked by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select Date";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(364, 470);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // selectVehicleComboBox
            // 
            this.selectVehicleComboBox.FormattingEnabled = true;
            this.selectVehicleComboBox.Location = new System.Drawing.Point(153, 22);
            this.selectVehicleComboBox.Name = "selectVehicleComboBox";
            this.selectVehicleComboBox.Size = new System.Drawing.Size(226, 21);
            this.selectVehicleComboBox.TabIndex = 2;
            // 
            // selectDateCalender
            // 
            this.selectDateCalender.Location = new System.Drawing.Point(48, 95);
            this.selectDateCalender.Name = "selectDateCalender";
            this.selectDateCalender.TabIndex = 3;
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.shiftComboBox.Location = new System.Drawing.Point(153, 292);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(183, 21);
            this.shiftComboBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(153, 405);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(183, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // bookedByTextBox
            // 
            this.bookedByTextBox.Location = new System.Drawing.Point(153, 353);
            this.bookedByTextBox.Name = "bookedByTextBox";
            this.bookedByTextBox.Size = new System.Drawing.Size(183, 20);
            this.bookedByTextBox.TabIndex = 5;
            // 
            // VehicleScheduleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 505);
            this.Controls.Add(this.bookedByTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.selectDateCalender);
            this.Controls.Add(this.selectVehicleComboBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "VehicleScheduleUI";
            this.Text = "VehicleScheduleUI";
            this.Load += new System.EventHandler(this.VehicleScheduleUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox selectVehicleComboBox;
        private System.Windows.Forms.MonthCalendar selectDateCalender;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox bookedByTextBox;
    }
}