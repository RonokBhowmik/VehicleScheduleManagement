using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleScheduleManagement.BLL;
using VehicleScheduleManagement.DAL.DAO;

namespace VehicleScheduleManagement.UI
{
    public partial class BookedSchedulesOfAVehicle : Form
    {
        public BookedSchedulesOfAVehicle()
        {
            InitializeComponent();
        }

        private void BookedSchedulesOfAVehicle_Load(object sender, EventArgs e)
        {
            List<VehicleInformation> allVehicles = new List<VehicleInformation>();
            VehicleScheduleManager vehicleScheduleManager = new VehicleScheduleManager();
            allVehicles = vehicleScheduleManager.GetAllVehicle();
            scheduleOfAVehicleComboBox.DataSource = allVehicles;
            scheduleOfAVehicleComboBox.DisplayMember = "RegNo";
            scheduleOfAVehicleComboBox.ValueMember = "EngineNo";
        }

        private void singleVehicleScheduleShowButton_Click(object sender, EventArgs e)
        {
            VehicleScheduleManager vehicleScheduleManager = new VehicleScheduleManager();
            VehicleInformation selectedVehicle = new VehicleInformation();
            selectedVehicle = (VehicleInformation) scheduleOfAVehicleComboBox.SelectedItem;
            try
            {
                if(vehicleScheduleManager.GetSchedulesOfASingleVehicle(selectedVehicle)!=null)
                {
                    schedulesOfAVehicleGridView.DataSource =
                        vehicleScheduleManager.GetSchedulesOfASingleVehicle(selectedVehicle);
                    schedulesOfAVehicleGridView.Show();
                }
                else
                {
                    MessageBox.Show("No Schedule is Booked :)");
                }
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show("Exception occured in UI! "+exceptionObj.Message);
            }
        }
    }
}
