using Ship_Web.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ship_Web
{
    public partial class Q3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
          
                // xu li cai dropdow
                DataTable dt2 = Database.GetDataBySQL("select * from Outcomes");
                dropdow.DataSource = dt2;
                dropdow.DataTextField = "ship";
                dropdow.DataValueField = "ship";
                dropdow.DataBind();
                //label count
                lb_Count.Text = "Number of rows: 0";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (!cb_Ship.Checked)
            {
                DataTable dt1 = Database.GetDataBySQL("select * from Outcomes");
                gv_Ship.DataSource = dt1;
                gv_Ship.DataBind();
                lb_Count.Text = "Number of rows: "+dt1.Rows.Count;
            }
            else
            {
                string ship = dropdow.SelectedValue.ToString().Trim();
                DataTable dt3 = Database.GetDataBySQL("select * from Outcomes where Ship = '"+ship+"'");
                gv_Ship.DataSource = dt3;
                gv_Ship.DataBind();
                lb_Count.Text = "Number of rows: " + dt3.Rows.Count;
            }
        }
    }
}