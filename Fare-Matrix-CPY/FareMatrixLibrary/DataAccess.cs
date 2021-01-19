using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FareMatrixLibrary
{
    public class DataAccess
    {
        string connectionString = Connection.ConnectionString;
        SqlConnection connection = new SqlConnection();
        SqlDataReader reader;
        SqlCommand command = new SqlCommand();

        public string query { get; set; }

        public bool DataRetrieval()//Get all the data from the database
        {
            bool IsRetrieve = false;
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if(reader.Read() == true)
            {
                IsRetrieve = true;
            }

            connection.Close();
            return IsRetrieve;
        }

        public void DataExecution()//Executes the query
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
