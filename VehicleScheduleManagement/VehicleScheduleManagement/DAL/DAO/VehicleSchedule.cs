using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleScheduleManagement.DAL.DAO
{
    public class VehicleSchedule
    {
        public DateTime SelectedDate { set; get; }
        public string SelectShift { set; get; }
        public string BookedBy { set; get; }
        public string Address { set; get; }
        public VehicleInformation Vehicle = new VehicleInformation();
       
    }
}
