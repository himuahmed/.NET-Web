using MobileInformationKeeper.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MobileInformationKeeper.DAL
{
    public class MobileGateway
    {
        string connectionString = @"Server=DESKTOP-40V57DS;Database=mobileInfoDB;Integrated Security=true";
        public bool saveMobile(Mobile mobile)
        {
            string connectionString = @"Server=DESKTOP-40V57DS;Database=mobileInfoDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            string insertQuery = "INSERT INTO mobile_tbl(ModelName,Imei,Price) VALUES ('" + mobile.ModelName + "','" + mobile.Imei + "'," + mobile.Price + ")";

            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Mobile getExistsMobile(Mobile mobile)
        {
            string connectionString = @"Server=DESKTOP-40V57DS;Database=mobileInfoDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string searchQuery = "SELECT * FROM mobile_tbl WHERE Imei = '" + mobile.Imei + "'";

            SqlCommand command = new SqlCommand(searchQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Mobile aMobile = null;
            while (reader.Read())
            {
                aMobile = new Mobile();
                aMobile.MobileId = Convert.ToInt32(reader["mobileId"]);
                aMobile.ModelName = reader["ModelName"].ToString();
                aMobile.Imei = reader["Imei"].ToString();
                aMobile.Price = Convert.ToInt32(reader["Price"]);
            }
            reader.Close();
            connection.Close();
            return aMobile;
        }

        public List<Mobile> getMobileByPrice(Mobile mobile)
        {
           // Mobile mobile = new Mobile();
            List<Mobile> mobileList = new List<Mobile>();
            string connectionString = @"Server=DESKTOP-40V57DS;Database=mobileInfoDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string searchQuery = "SELECT * FROM mobile_tbl WHERE Price BETWEEN " + mobile.Price1 + " AND "+mobile.Price2+"";

            SqlCommand command = new SqlCommand(searchQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Mobile aMobile = new Mobile();
                aMobile.MobileId = Convert.ToInt32(reader["mobileId"]);
                aMobile.ModelName = reader["ModelName"].ToString();
                aMobile.Imei = reader["Imei"].ToString();
                aMobile.Price = Convert.ToInt32(reader["Price"]);
                mobileList.Add(aMobile);

            }
            reader.Close();
            connection.Close();
            return mobileList;
        }

        public List<Mobile> getMobile()
        {
            //Mobile mobile = new Mobile();
            List<Mobile> mobileList = new List<Mobile>();
            string connectionString = @"Server=DESKTOP-40V57DS;Database=mobileInfoDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string searchQuery = "SELECT * FROM mobile_tbl ";
            SqlCommand command = new SqlCommand(searchQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Mobile aMobile = new Mobile();
                aMobile.MobileId = Convert.ToInt32(reader["mobileId"]);
                aMobile.ModelName = reader["ModelName"].ToString();
                aMobile.Imei = reader["Imei"].ToString();
                aMobile.Price = Convert.ToInt32(reader["Price"]);
                mobileList.Add(aMobile);

            }
            reader.Close();
            connection.Close();
            return mobileList;
        }


        public Mobile getMobileByImei(Mobile mobile)
        {
            //Mobile mobile = new Mobile();
            //List<Mobile> mobileList = new List<Mobile>();
            string connectionString = @"Server=DESKTOP-40V57DS;Database=mobileInfoDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            string searchQuery = "SELECT * FROM mobile_tbl WHERE Imei = "+mobile.Imei+" ";
            SqlCommand command = new SqlCommand(searchQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            Mobile aMobile = null;
            while (reader.Read())
            {
                aMobile = new Mobile();
                aMobile.MobileId = Convert.ToInt32(reader["mobileId"]);
                aMobile.ModelName = reader["ModelName"].ToString();
                aMobile.Imei = reader["Imei"].ToString();
                aMobile.Price = Convert.ToInt32(reader["Price"]);
               // mobileList.Add(aMobile);

            }
            reader.Close();
            connection.Close();
            return aMobile; ;
        }



    }
}