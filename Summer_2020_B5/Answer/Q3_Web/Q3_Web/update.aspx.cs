using Q3_Web.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3_Web
{
    public partial class update : System.Web.UI.Page
    {

        internal static int UpdateBooks(ArrayList arrayList)
        {
            string sql = "UPDATE [dbo].[Books] SET [Title] = @title ,[Year] = @year,[Description] =@des WHERE ID= @Id ";
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@title", SqlDbType.NVarChar),
            new SqlParameter("@year", SqlDbType.Int),
            new SqlParameter("@des", SqlDbType.NText),
              new SqlParameter("@id", SqlDbType.Int)
            };
            //Gán giá trị cho các tham số của câu truy vấn
            for (int i = 0; i < arrayList.Count; i++)
            {
                para[i].Value = arrayList[i];
            }
            return Database.ExcuteSQL(sql, para);
        }
        private static DataTable GetBookByCatId(int Id)
        {
            string sql = "select * from Books where ID= "+Id;
            return Database.GetDataBySQL(sql);
        }

   

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                int idB = Convert.ToInt32(Request.Params["id"]);
                DataTable dt = GetBookByCatId(idB);
                txt_ID.Text = dt.Rows[0][0].ToString();
                txt_Title.Text = dt.Rows[0][1].ToString();
                txt_Year.Text = dt.Rows[0][2].ToString();
                txt_Des.Text = dt.Rows[0][3].ToString();

            }

        }

        protected void bt_Save_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            string title = txt_Title.Text;
            int year = Convert.ToInt32(txt_Year.Text);
            string des = txt_Des.Text;
            ArrayList arr = new ArrayList() { title, year, des, id };
            int k = UpdateBooks(arr);
            Response.Redirect("books.aspx");
        }
    }
}