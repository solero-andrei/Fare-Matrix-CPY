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
        readonly SqlConnection connection;
        
        public string query { get; set; }

        public DataAccess()
        {
            connection = new SqlConnection(connection.ConnectionString);
        }

        public virtual bool DataRetrieval()//Get all the data from the database
        {
            bool IsRetrieve = false;
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                IsRetrieve = true;
            }

            connection.Close();
            return IsRetrieve;
        }

        public virtual void DataExecution()//Executes the query
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
