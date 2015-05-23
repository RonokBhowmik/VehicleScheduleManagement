using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleScheduleManagement.DAL.Gateway;

namespace VehicleScheduleManagement.BLL
{
    public class VehicleInformationManager
    {
        VehicleInformationGateway vehicleInformationGateway = new VehicleInformationGateway();
        public bool Save(string regNo, string engineNo)
        {
            try
            {
                if (!HasThisRegNo(regNo))
                {
                    if (!HasThisEngineNo(engineNo))
                    {
                        vehicleInformationGateway.Save(regNo, engineNo);
                        return true;    
                    }
                }
            }
            catch (Exception exceptionObj)
            {
                throw new Exception("Vehicle information can't be saved in your system.",exceptionObj);
            }
            return false;
        }

        public bool HasThisRegNo(string regNo)
        {
            List<string> allRegNo = vehicleInformationGateway.GetAllRegNo();
            foreach (string aRegNo in allRegNo)
            {
                if (aRegNo == regNo)
                {
                    return true;   
                }
            }
            return false;
        }
        
        public bool HasThisEngineNo(string engineNo)
        {
            List<string> allEngineNo = vehicleInformationGateway.GetAllEngineNo();
            foreach (string anEngineNo in allEngineNo)
            {
                if (anEngineNo == engineNo)
                {
                    return true;  
                }
            }
            return false;
        }
    }
}
