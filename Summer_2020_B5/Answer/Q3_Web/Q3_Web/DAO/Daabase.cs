using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Q3_Web.DAO
{
    static class Database
    {   //select: Trích xuất dữ liệu--> Disconected
        internal static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["PRN292"].ToString());
        }
        internal static DataTable GetDataBySQL(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); //Database cache (client)
            da.Fill(ds);
            return ds.Tables[0];
        }
        // Insert ,Update,Delete-->Connected
        internal static int ExcuteSQL(string sql, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Parameters.AddRange(sqlParameters);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            return result;

        }
        internal static void Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}