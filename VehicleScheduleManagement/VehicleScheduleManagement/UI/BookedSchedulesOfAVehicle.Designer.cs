namespace VehicleScheduleManagement.UI
{
    partial class BookedSchedulesOfAVehicle
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
            this.schedulesOfAVehicleGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesOfAVehicleGridView)).BeginInit();
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
            this.singleVehicleScheduleShowButton.Click += new System.EventHandler(this.singleVehicleScheduleShowButton_Click);
            // 
            // scheduleOfAVehicleComboBox
            // 
            this.scheduleOfAVehicleComboBox.FormattingEnabled = true;
            this.scheduleOfAVehicleComboBox.Location = new System.Drawing.Point(114, 53);
            this.scheduleOfAVehicleComboBox.Name = "scheduleOfAVehicleComboBox";
            this.scheduleOfAVehicleComboBox.Size = new System.Drawing.Size(218, 21);
            this.scheduleOfAVehicleComboBox.TabIndex = 3;
            // 
            // schedulesOfAVehicleGridView
            // 
            this.schedulesOfAVehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulesOfAVehicleGridView.Location = new System.Drawing.Point(36, 94);
            this.schedulesOfAVehicleGridView.Name = "schedulesOfAVehicleGridView";
            this.schedulesOfAVehicleGridView.Size = new System.Drawing.Size(421, 213);
            this.schedulesOfAVehicleGridView.TabIndex = 4;
            // 
            // BookedSchedulesOfAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 326);
            this.Controls.Add(this.schedulesOfAVehicleGridView);
            this.Controls.Add(this.scheduleOfAVehicleComboBox);
            this.Controls.Add(this.singleVehicleScheduleShowButton);
            this.Controls.Add(this.label1);
            this.Name = "BookedSchedulesOfAVehicle";
            this.Text = "View Schedule of a Vehicle";
            this.Load += new System.EventHandler(this.BookedSchedulesOfAVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulesOfAVehicleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singleVehicleScheduleShowButton;
        private System.Windows.Forms.ComboBox scheduleOfAVehicleComboBox;
        private System.Windows.Forms.DataGridView schedulesOfAVehicleGridView;
    }
}