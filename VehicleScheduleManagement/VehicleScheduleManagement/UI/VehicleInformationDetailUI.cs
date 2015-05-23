using System;
using System.Windows.Forms;
using VehicleScheduleManagement.BLL;
using VehicleScheduleManagement.DAL.DAO;

namespace VehicleScheduleManagement.UI
{
    public partial class VehicleInformationDetailUI : Form
    {
        public VehicleInformationDetailUI()
        {
            InitializeComponent();
        }

        private void informationSaveButton_Click(object sender, EventArgs e)
        {
            VehicleInformationManager vehicleInformationManager = new VehicleInformationManager();
            if(regNoTextBox.Text!="" && engineNoTextBox.Text!= "")
            {
                try
                {
                    if (vehicleInformationManager.Save(regNoTextBox.Text, engineNoTextBox.Text))
                    {
                        MessageBox.Show("Engine Information is saved.");
                    }
                    else
                    {
                        MessageBox.Show("You have this RegNo/EngineNo in your system.");
                    }
                }
                catch (Exception exceptionObj)
                {
                    MessageBox.Show("An Exception Occured: " + exceptionObj.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter text.");
            }
            regNoTextBox.Text = string.Empty;
            engineNoTextBox.Text = string.Empty;

        }
    }
}
