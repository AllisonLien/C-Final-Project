using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pet_Adoption_and_Shelter_Management_System
{
    public class Database
    {
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public string PortNumber { get; set; }

        public Database(string serverAddress, string userName, string password, string databaseName, string portNumber)
        {
            ServerAddress = serverAddress;
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            PortNumber = portNumber;
        }
        public MySqlConnection Connect()
        {
            string connStr =
                $"Server={ServerAddress};Port={PortNumber};User Id={UserName};Password={Password};Database={DatabaseName};";

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                //conn.Open();    
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connecting to database: " + ex.Message);
                return null;
            }
        }
    }
}
