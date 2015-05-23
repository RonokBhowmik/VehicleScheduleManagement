namespace VehicleScheduleManagement.UI
{
    partial class ScheduleOfAVehicle
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
            this.singleVehicleScheduleShowButton = new System.Windows.Forms.Button();
            this.scheduleOfAVehicleComboBox = new System.Windows.Forms.ComboBox();
            this.singleVehicleListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vehicle";
            // 
            // singleVehicleScheduleShowButton
            // 
            this.singleVehicleScheduleShowButton.Location = new System.Drawing.Point(382, 53);
            this.singleVehicleScheduleShowButton.Name = "singleVehicleScheduleShowButton";
            this.singleVehicleScheduleShowButton.Size = new System.Drawing.Size(75, 23);
            this.singleVehicleScheduleShowButton.TabIndex = 2;
            this.singleVehicleScheduleShowButton.Text = "Show";
            this.singleVehicleScheduleShowButton.UseVisualStyleBackColor = true;
            // 
            // scheduleOfAVehicleComboBox
            // 
            this.scheduleOfAVehicleComboBox.FormattingEnabled = true;
            this.scheduleOfAVehicleComboBox.Location = new System.Drawing.Point(114, 53);
            this.scheduleOfAVehicleComboBox.Name = "scheduleOfAVehicleComboBox";
            this.scheduleOfAVehicleComboBox.Size = new System.Drawing.Size(218, 21);
            this.scheduleOfAVehicleComboBox.TabIndex = 3;
            // 
            // singleVehicleListView
            // 
            this.singleVehicleListView.Location = new System.Drawing.Point(56, 103);
            this.singleVehicleListView.Name = "singleVehicleListView";
            this.singleVehicleListView.Size = new System.Drawing.Size(401, 185);
            this.singleVehicleListView.TabIndex = 4;
            this.singleVehicleListView.UseCompatibleStateImageBehavior = false;
            // 
            // ScheduleOfAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 319);
            this.Controls.Add(this.singleVehicleListView);
            this.Controls.Add(this.scheduleOfAVehicleComboBox);
            this.Controls.Add(this.singleVehicleScheduleShowButton);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleOfAVehicle";
            this.Text = "View Schedule of a Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singleVehicleScheduleShowButton;
        private System.Windows.Forms.ComboBox scheduleOfAVehicleComboBox;
        private System.Windows.Forms.ListView singleVehicleListView;
    }
}