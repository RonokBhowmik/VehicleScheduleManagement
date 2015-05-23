namespace VehicleScheduleManagement.UI
{
    partial class VehicleScheduleManagementUI
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
            this.vehicleEntryButton = new System.Windows.Forms.Button();
            this.scheduleVehicleButton = new System.Windows.Forms.Button();
            this.bookedScheduleButton = new System.Windows.Forms.Button();
            this.dateBetweenScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleEntryButton
            // 
            this.vehicleEntryButton.Location = new System.Drawing.Point(110, 79);
            this.vehicleEntryButton.Name = "vehicleEntryButton";
            this.vehicleEntryButton.Size = new System.Drawing.Size(126, 48);
            this.vehicleEntryButton.TabIndex = 0;
            this.vehicleEntryButton.Text = "Vehicle Entry";
            this.vehicleEntryButton.UseVisualStyleBackColor = true;
            this.vehicleEntryButton.Click += new System.EventHandler(this.vehicleEntryButton_Click);
            // 
            // scheduleVehicleButton
            // 
            this.scheduleVehicleButton.Location = new System.Drawing.Point(302, 79);
            this.scheduleVehicleButton.Name = "scheduleVehicleButton";
            this.scheduleVehicleButton.Size = new System.Drawing.Size(114, 48);
            this.scheduleVehicleButton.TabIndex = 0;
            this.scheduleVehicleButton.Text = "Schedule Vehicle";
            this.scheduleVehicleButton.UseVisualStyleBackColor = true;
            this.scheduleVehicleButton.Click += new System.EventHandler(this.scheduleVehicleButton_Click);
            // 
            // bookedScheduleButton
            // 
            this.bookedScheduleButton.Location = new System.Drawing.Point(110, 174);
            this.bookedScheduleButton.Name = "bookedScheduleButton";
            this.bookedScheduleButton.Size = new System.Drawing.Size(126, 48);
            this.bookedScheduleButton.TabIndex = 0;
            this.bookedScheduleButton.Text = "View Booked Schedule of a Vehicle";
            this.bookedScheduleButton.UseVisualStyleBackColor = true;
            this.bookedScheduleButton.Click += new System.EventHandler(this.bookedScheduleButton_Click);
            // 
            // dateBetweenScheduleButton
            // 
            this.dateBetweenScheduleButton.Location = new System.Drawing.Point(302, 174);
            this.dateBetweenScheduleButton.Name = "dateBetweenScheduleButton";
            this.dateBetweenScheduleButton.Size = new System.Drawing.Size(114, 48);
            this.dateBetweenScheduleButton.TabIndex = 0;
            this.dateBetweenScheduleButton.Text = "View Date Between Schedule";
            this.dateBetweenScheduleButton.UseVisualStyleBackColor = true;
            this.dateBetweenScheduleButton.Click += new System.EventHandler(this.dateBetweenScheduleButton_Click);
            // 
            // VehicleScheduleManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 316);
            this.Controls.Add(this.dateBetweenScheduleButton);
            this.Controls.Add(this.scheduleVehicleButton);
            this.Controls.Add(this.bookedScheduleButton);
            this.Controls.Add(this.vehicleEntryButton);
            this.Name = "VehicleScheduleManagementUI";
            this.Text = "VehicleScheduleManagementUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vehicleEntryButton;
        private System.Windows.Forms.Button scheduleVehicleButton;
        private System.Windows.Forms.Button bookedScheduleButton;
        private System.Windows.Forms.Button dateBetweenScheduleButton;
    }
}