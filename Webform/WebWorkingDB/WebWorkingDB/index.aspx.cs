using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWorkingDB
{
    public partial class index : System.Web.UI.Page
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ProductDB"].ToString());
        }
        public static DataTable GetDataBySQL(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); //Database cache (client)
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetAllCategory()
        {
            return GetDataBySQL("select * from Categories");
        }
        public static DataTable GetProductByCatId(string catId)
        {
            return GetDataBySQL("select * from Products where CategoryId = '"+catId+"'");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCategory.DataSource = GetAllCategory();
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryId";
                ddlCategory.DataBind();
               // ddlCategory.Items.Insert(0, new ListItem("--Choose Itemt--", "0"));
              
                
                //Get CatId tu ddlCategory
                string catId = ddlCategory.SelectedValue;
                gvProduct.DataSource = GetProductByCatId(catId);
                gvProduct.DataBind();
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catId = ddlCategory.SelectedValue;
            gvProduct.DataSource = GetProductByCatId(catId);
            gvProduct.DataBind();
        }
    }
}