using Q3_Web.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3_Web
{
    public partial class books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = Database.GetDataBySQL("select * from Books");
                gv_Book.DataSource = dt;
                gv_Book.DataBind();
            }
        }
    }
}