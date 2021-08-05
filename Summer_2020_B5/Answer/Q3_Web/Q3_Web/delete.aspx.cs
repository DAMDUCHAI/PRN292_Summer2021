using Q3_Web.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3_Web
{
    public partial class delete : System.Web.UI.Page
    {
        internal static int DeleteAuthor_Book(int Id)
        {
            int result = 0;
           
                //Thực hiện xóa
                string sql = "delete from Author_Book where BookID = "+Id;
            string sql1 = "delete from Books where ID = "+Id;

           
            Database.Execute(sql);
            Database.Execute(sql1);
           ;
            return result;
        }




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int idB =Convert.ToInt32(Request.Params["id"]);
                int ab = DeleteAuthor_Book(idB);
            }
            Response.Redirect("books.aspx");
        }
    }
}