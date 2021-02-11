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
        public SqlDataReader reader;
        //public string[] data;
        public string[] data { get; set; }

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
            UserModel user = new UserModel();
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    hasGet = true;
                    data = new string[reader.VisibleFieldCount];
                    data[0] = reader["UserID"].ToString();
                    data[1] = reader["FirstName"].ToString();
                    data[2] = reader["MiddleName"].ToString();
                    data[3] = reader["LastName"].ToString();
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
