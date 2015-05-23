using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleScheduleManagement.DAL.DAO;
using VehicleScheduleManagement.DAL.Gateway;

namespace VehicleScheduleManagement.BLL
{
    public class VehicleScheduleManager
    {
        VehicleInformationGateway vehicleInformationGateway = new VehicleInformationGateway();
        private VehicleScheduleGateway _vehicleScheduleGateway = new VehicleScheduleGateway();
        VehicleSchedule _vehicleSchedule = new VehicleSchedule();
        private string message="";

        public List<VehicleInformation> GetAllVehicle()
        {
            return vehicleInformationGateway.GetAllVehicle();
        } 

        public bool GetVehicleSchedule(VehicleInformation vehicle, DateTime selectedDate,string shift, string bookedBy, string address, out string msg)
        {
            try
            {
                if(!IsScheduleBooked(vehicle,selectedDate,shift))
                {
                    _vehicleScheduleGateway.SaveSchedule(vehicle, selectedDate, shift, bookedBy, address);
                    msg = message;
                    return true;
                }
            }
            catch (Exception exceptionObj)
            {
                throw new Exception("Exception occured! Schedule can not be saved.",exceptionObj);
            }
            msg = message;
            return false;
        }

        public bool IsScheduleBooked(VehicleInformation vehicle, DateTime selectedDate, string shift)
        {
            VehicleSchedule vehicleSchedule = new VehicleSchedule();
            vehicleSchedule = _vehicleScheduleGateway.IsScheduleBooked(vehicle, selectedDate, shift);
            if(vehicleSchedule!=null)
            {
                message = string.Format("This schedule is already booked by : {0}", vehicleSchedule.BookedBy);
                return true;
            }
            message = string.Format("New Schedule is saved!");
            return false;
        }
        public List<SchedulesOfAVehicle>GetSchedulesOfASingleVehicle(VehicleInformation vehicle)
        {
            try
            {
                if(_vehicleScheduleGateway.GetSchedulesOfASingleVehicle(vehicle)!=null)
                {
                    return _vehicleScheduleGateway.GetSchedulesOfASingleVehicle(vehicle);
                }
            }
            catch (Exception exceptionObj)
            {
                throw new Exception("Exception Occured!!",exceptionObj);
            }
            return null;
        }
 
        public List<DateBetweenSchedule> GetDateBetweenSchedule(DateTime startDate, DateTime endDate)
        {
            if(_vehicleScheduleGateway.GetDateBetweenSchedule(startDate,endDate)!=null)
            {
                return _vehicleScheduleGateway.GetDateBetweenSchedule(startDate, endDate);
            }
            return null;    
        } 
    }
}
