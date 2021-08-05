using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WinformProduct.DAO
{
    class Database
    {
        internal static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ProductDB"].ToString());
        }
        //select:trích xuất dữ liệu -> Disconnected
        internal static DataTable GetDataBySQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //insert into Categories value('C1234','ABC','DEF')
        //insert, update, delete ->> Connected
        internal static int ExecuteSQL(string sql, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Parameters.AddRange(sqlParameters);
            cmd.Connection.Open();
            int numRows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return numRows;
        }
    }
}
