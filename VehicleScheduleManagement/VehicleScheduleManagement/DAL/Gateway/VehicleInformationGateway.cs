using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VehicleScheduleManagement.DAL.DAO;

namespace VehicleScheduleManagement.DAL.Gateway
{
    public class VehicleInformationGateway:DBGateway
    {
        public bool Save(string regNo, string engineNo)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("insert into vehicleinformation values('{0}','{1}')",regNo,engineNo);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();

            }
            catch (Exception exceptionObj)
            {
                
                throw new Exception("Can not be saved in your system",exceptionObj);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return true;
        }

        public List<string> GetAllRegNo()
        {
            List<string> allRegNo = new List<string>();
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select RegNo from VehicleInformation");
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while(reader.Read())
                {
                    string regNo = reader[0].ToString();
                    allRegNo.Add(regNo);
                }
            }
            catch (Exception exceptionObj)
            {
                throw new Exception("Registration number can not be loaded.", exceptionObj);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return allRegNo;
        }

        public List<string> GetAllEngineNo()
        {
            List<string> allEngineNo = new List<string>();
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select EngineNo from VehicleInformation");
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    string regNo = reader[0].ToString();
                    allEngineNo.Add(regNo);
                }
            }
            catch (Exception exceptionObj)
            {

                throw new Exception("Engine Num. can not be loaded.", exceptionObj);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return allEngineNo;
        }

        public List<VehicleInformation> GetAllVehicle()
        {
            List<VehicleInformation> allVehicles = new List<VehicleInformation>();
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from VehicleInformation");
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    VehicleInformation aVehicleInformation = new VehicleInformation();
                    aVehicleInformation.RegNo = reader[0].ToString();
                    aVehicleInformation.EngineNo = reader[1].ToString();
                    allVehicles.Add(aVehicleInformation);
                }
            }
            catch (Exception exceptionObj)
            {

                throw new Exception("Vehicle inforamtion number can not be loaded.", exceptionObj);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return allVehicles;
        }
    }
}
