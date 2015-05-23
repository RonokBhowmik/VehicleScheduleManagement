using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleScheduleManagement.DAL.DAO
{
    public class ScheduleVehicle
    {
        public DateTime SelectedDate { set; get; }
        public string SelectShift { set; get; }
        public string BookedBy { set; get; }
        public string Address { set; get; }
        private VehicleInformation vehicle = new VehicleInformation();
        public VehicleInformation Vehicle { set; get; }
    }
}
