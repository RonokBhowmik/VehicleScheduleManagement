namespace VehicleScheduleManagement.UI
{
    partial class VehicleInformationDetailUI
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
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.engineNoTextBox = new System.Windows.Forms.TextBox();
            this.informationSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Information Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Engine No";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(138, 86);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(193, 20);
            this.regNoTextBox.TabIndex = 2;
            // 
            // engineNoTextBox
            // 
            this.engineNoTextBox.Location = new System.Drawing.Point(138, 132);
            this.engineNoTextBox.Name = "engineNoTextBox";
            this.engineNoTextBox.Size = new System.Drawing.Size(193, 20);
            this.engineNoTextBox.TabIndex = 2;
            // 
            // informationSaveButton
            // 
            this.informationSaveButton.Location = new System.Drawing.Point(256, 189);
            this.informationSaveButton.Name = "informationSaveButton";
            this.informationSaveButton.Size = new System.Drawing.Size(75, 23);
            this.informationSaveButton.TabIndex = 3;
            this.informationSaveButton.Text = "Save";
            this.informationSaveButton.UseVisualStyleBackColor = true;
            this.informationSaveButton.Click += new System.EventHandler(this.informationSaveButton_Click);
            // 
            // VehicleInformationDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.informationSaveButton);
            this.Controls.Add(this.engineNoTextBox);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleInformationDetailUI";
            this.Text = "VehicleInformationDetailUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.TextBox engineNoTextBox;
        private System.Windows.Forms.Button informationSaveButton;
    }
}

