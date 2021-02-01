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
                string query = $"INSERT INTO {tableName} ({attributes})VALUES({values})"; ;

                command.Connection = conn;
                command.CommandText = query;

                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
