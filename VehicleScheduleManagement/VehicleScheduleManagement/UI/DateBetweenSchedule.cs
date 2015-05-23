using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleScheduleManagement.BLL;

namespace VehicleScheduleManagement.UI
{
    public partial class DateBetweenSchedule : Form
    {
        public DateBetweenSchedule()
        {
            InitializeComponent();
        }

        private void showDateBetweenScheduleButton_Click(object sender, EventArgs e)
        {
            VehicleScheduleManager vehicleScheduleManager = new VehicleScheduleManager();
            try
            {
                DateTime selectedStartDate = startMonthCalendar.SelectionRange.Start;
                DateTime selectedEndDate = endMonthCalendar.SelectionRange.Start;
                
                if (vehicleScheduleManager.GetDateBetweenSchedule(selectedStartDate, selectedEndDate) != null)
                {
                    dateBetweenDataGridView.DataSource = vehicleScheduleManager.GetDateBetweenSchedule(
                        selectedStartDate, selectedEndDate);
                    dateBetweenDataGridView.Show();
                }
                else
                {
                    MessageBox.Show("No Schedule in this interval.");
                }
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message);
            }
        }
    }
}
