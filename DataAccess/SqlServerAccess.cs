using Microsoft.Data.SqlClient;
using System;

namespace DataAccess
{
    public class SqlServerAccess
    {
        public SqlServerAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

         public string ConnectionString { get; init; }

        public string ConnectToDb(string firstName,string surname, string printerCode)
        {

            string msg = String.Empty;

            using (SqlConnection cn = new())
            {
                cn.ConnectionString = ConnectionString;
                cn.Open();
                using SqlCommand cmd = new();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spInsert_Facilitator";
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@PrinterCode", printerCode);
                cmd.Parameters.AddWithValue("@Msg", msg);

                //ddddddd
                cmd.ExecuteNonQuery();
            }
                return "Success";


        }
    }
}
