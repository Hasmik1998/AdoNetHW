using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Adooonet
{
    class Program
    {
        static void StoredProc(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string storedProcQuery = "CREATE PROCEDURE User AS SELECT* FROM Uers GO";
                SqlCommand procCommand = new SqlCommand(storedProcQuery, connection);
                procCommand.ExecuteNonQuery();
                string execute = "EXEC Users";
                SqlCommand procexecCommand = new SqlCommand(execute, connection);
                procexecCommand.ExecuteNonQuery();
            }
        }
        static void Main(string[] args)
        {
            string connectionString = "Data Source =.\\sqlexpress; Initial Catalog = people; Integrated Security = True";
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                //string insertQuery = "INSERT INTO Team(T_ID,Triner,Team_name)VALUES(9, ' Matt Nagy', 'Chicago Bears')";
                //SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                //insertCommand.ExecuteNonQuery();
                //string updateQueary = "UPDATE Users SET Lastname='Petrosyan' where ID =2";
                //SqlCommand updateCommand = new SqlCommand(updateQueary, connection);
                //updateCommand.ExecuteNonQuery();
                //string delateQuery = "Delete FROM Users WHERE ID=9";
                //SqlCommand delateCommand = new SqlCommand(delateQuery, connection);
                //delateCommand.ExecuteNonQuery();
            }
        }
    }
}
