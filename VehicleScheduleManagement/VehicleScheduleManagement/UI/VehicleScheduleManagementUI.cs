using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VehicleScheduleManagement.UI
{
    public partial class VehicleScheduleManagementUI : Form
    {
        public VehicleScheduleManagementUI()
        {
            InitializeComponent();
        }

        private void vehicleEntryButton_Click(object sender, EventArgs e)
        {
            VehicleInformationDetailUI vehicleInformationDetailUi = new VehicleInformationDetailUI();
            vehicleInformationDetailUi.ShowDialog();
        }

        private void scheduleVehicleButton_Click(object sender, EventArgs e)
        {
            VehicleScheduleUI vehicleScheduleUi = new VehicleScheduleUI();
            vehicleScheduleUi.ShowDialog();
        }

        private void bookedScheduleButton_Click(object sender, EventArgs e)
        {
            BookedSchedulesOfAVehicle bookedSchedulesOfAVehicle = new BookedSchedulesOfAVehicle();
            bookedSchedulesOfAVehicle.ShowDialog();
        }

        private void dateBetweenScheduleButton_Click(object sender, EventArgs e)
        {
            DateBetweenSchedule dateBetweenSchedule = new DateBetweenSchedule();
            dateBetweenSchedule.ShowDialog();
        }
    }
}
