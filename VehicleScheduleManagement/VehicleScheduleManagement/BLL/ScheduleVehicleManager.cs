using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleScheduleManagement.DAL.DAO;
using VehicleScheduleManagement.DAL.Gateway;

namespace VehicleScheduleManagement.BLL
{
    public class ScheduleVehicleManager
    {
        VehicleInformationGateway vehicleInformationGateway = new VehicleInformationGateway();
        private ScheduleVehicleGateway scheduleVehicleGateway = new ScheduleVehicleGateway();
        ScheduleVehicle scheduleVehicle = new ScheduleVehicle();

        public List<VehicleInformation> GetAllVehicle()
        {
            return vehicleInformationGateway.GetAllVehicle();
        } 
        public bool GetVehicleSchedule(VehicleInformation vehicle, DateTime selectedDate,string shift, string bookedBy, string address)
        {
            try
            {
                if(!IsScheduleBooked(vehicle,selectedDate,shift))
                {
                    scheduleVehicleGateway.SaveSchedule(vehicle, selectedDate, shift, bookedBy, address);
                    return true;
                }
            }
            catch (Exception exceptionObj)
            {
                throw new Exception("Exception occured! Schedule can not be saved.",exceptionObj);
            }
            return false;
        }

        public bool IsScheduleBooked(VehicleInformation vehicle, DateTime selectedDate, string shift)
        {
            ScheduleVehicle vehicleSchedule = new ScheduleVehicle();
            vehicleSchedule = scheduleVehicleGateway.IsScheduleBooked(vehicle, selectedDate, shift);
            if(vehicleSchedule!=null)
            {
                string msg = string.Format("This schedule is already booked by : {0}", vehicleSchedule.BookedBy);
                return true;
            }
            return false;
        }
    }
}
