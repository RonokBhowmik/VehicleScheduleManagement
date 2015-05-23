﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VehicleScheduleManagement.DAL.DAO;

namespace VehicleScheduleManagement.DAL.Gateway
{
    public class ScheduleVehicleGateway:DBGateway
    {
        
        public bool SaveSchedule(VehicleInformation vehicle, DateTime selectedDate, string shift, string bookedBy, string address)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("INSERT INTO ScheduleVehicle VALUES('{0}',{1},'{2}','{3}','{4}')", vehicle.RegNo, selectedDate, shift, bookedBy, address);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
                return true;
            }
            catch (Exception exceptionObj)
            {
                
                throw new Exception("Schedule can not be saved!",exceptionObj);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return false;
        }

        public ScheduleVehicle IsScheduleBooked(VehicleInformation vehicle, DateTime selectedDate, string shift)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("SELECT * FROM ScheduleVehicle WHERE VehicleRegNo='{0}' AND Date='{1}' AND Shift='{2}'", vehicle.RegNo, selectedDate, shift);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                    while (reader.Read())
                    {
                        ScheduleVehicle vehicleSchedule = new ScheduleVehicle();
                        vehicleSchedule.Vehicle.RegNo = reader[0].ToString();
                        vehicleSchedule.SelectedDate = (DateTime)reader[1];
                        vehicleSchedule.SelectShift = reader[2].ToString();
                        vehicleSchedule.BookedBy = reader[3].ToString();
                        vehicleSchedule.Address = reader[4].ToString();
                        return vehicleSchedule; 
                    }
            }
            catch (Exception exceptionObj)
            {
                throw new Exception("Exception occured! In Schedule Booking.",exceptionObj);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return null;
        }
    }
}
