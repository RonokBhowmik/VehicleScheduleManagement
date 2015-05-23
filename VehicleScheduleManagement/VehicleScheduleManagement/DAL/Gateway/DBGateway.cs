using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VehicleScheduleManagement.DAL.Gateway
{
    public class DBGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public DBGateway()
        {
            connectionObj = new SqlConnection(ConfigurationSettings.AppSettings["connString"]);
            commandObj = new SqlCommand();
        }

        public SqlConnection SqlConnectionObj
        {
            get
            {
                return connectionObj;
            }
        }

        public SqlCommand SqlCommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
    }
}
