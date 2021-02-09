using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FareMatrixLibrary
{
    public class Repository: IRepository
    {

        public void Add(string tableName, string attributes, string values)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                string query = $"INSERT INTO {tableName} ({attributes})VALUES({values})";

                command.Connection = conn;
                command.CommandText = query;

                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        
        public bool Get(string query)
        {
            bool hasGet = false;
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    hasGet = true;
                }
                
                conn.Close();
            }

            return hasGet;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update(string tableName, string attributes, string values, string condition)
        {
            using(SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                string query = $"UPDATE {tableName} SET [{attributes}] = ('{values}') {condition}";

                command.Connection = conn;
                command.CommandText = query;

                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
