using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleScheduleManagement.BLL;
using VehicleScheduleManagement.DAL.DAO;

namespace VehicleScheduleManagement.UI
{
    public partial class VehicleScheduleUI : Form
    {
        public VehicleScheduleUI()
        {
            InitializeComponent();
        }

        private void VehicleScheduleUI_Load(object sender, EventArgs e)
        {
            List<VehicleInformation> allVehicles = new List<VehicleInformation>();
            VehicleScheduleManager vehicleScheduleManager = new VehicleScheduleManager();
            allVehicles = vehicleScheduleManager.GetAllVehicle();
            selectVehicleComboBox.DataSource = allVehicles;
            selectVehicleComboBox.DisplayMember = "RegNo";
            selectVehicleComboBox.ValueMember = "EngineNo";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            VehicleScheduleManager vehicleScheduleManager = new VehicleScheduleManager();
            string message;
            VehicleInformation selectedVehicleInformation = (VehicleInformation)selectVehicleComboBox.SelectedItem;
            DateTime selectedDateTime = selectDateCalender.SelectionRange.Start;
            if(bookedByTextBox.Text!=string.Empty && addressTextBox.Text!=string.Empty && selectedVehicleInformation!=null && selectedDateTime!=null && shiftComboBox.SelectedItem!=null)
            {
                try
                {
                    vehicleScheduleManager.GetVehicleSchedule(selectedVehicleInformation,selectedDateTime,shiftComboBox.SelectedItem.ToString(),bookedByTextBox.Text,addressTextBox.Text,out message);
                    MessageBox.Show(message);
                    this.Close();
                }
                catch (Exception exceptionObj)
                {
                    MessageBox.Show("Exception occured in VehicleScheduleUI: "+exceptionObj.Message);
                }
            }
            else
            {
                MessageBox.Show("Fillup all! ");
            }
        }
    }
}
