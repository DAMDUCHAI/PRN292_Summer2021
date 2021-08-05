using Q2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void Form1_Load(object sender, EventArgs e)
        {
             dataTable = Database.GetDataBySQL("select * from Books");
            cb_Book.DataSource = dataTable;
            cb_Book.DisplayMember = "Title";
            cb_Book.ValueMember = "ID";


            for(int i=2000; i <= 2010; i++)
            {
                cb_Year.Items.Add(i);
            }
            cb_Year.SelectedIndex = 0;

            //xu li listBox
            DataTable dataTable1 = Database.GetDataBySQL("select * from Authors");
            lb_Author.DataSource = dataTable1;
            lb_Author.DisplayMember = "Name";
        }

        private void cb_Book_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Book.DataSource = dataTable;
            cb_Book.DisplayMember = "Title";
            cb_Book.ValueMember = "ID";
            string id = cb_Book.SelectedValue.ToString().Trim();
            DataTable dataTable3 = Database.GetDataBySQL("select a.ID as IDA,b.ID,b.Title,b.[Year]  , a.Name from Books as b left join Author_Book as ab on b.ID=ab.BookID  left join Authors as a on a.ID=ab.AuthorID where b.ID = " + id);
            cb_Year.Items.Clear();

            string year = dataTable3.Rows[0][3].ToString();
            

            cb_Year.Items.Add(year);
            cb_Year.SelectedIndex = 0;
            lb_Author.DataSource = dataTable3;


            lb_Author.DisplayMember = "Name";
            lb_Author.ValueMember = "IDA";



        }
        internal static int DeleteAuthor_Book(int idbook,int idAuthor)
        {
               int result=0;
                //Thực hiện xóa
                string sql = "delete from Author_Book where BookID = @book and AuthorID=@author";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@book", SqlDbType.Int),
               new SqlParameter("@author",SqlDbType.Int)
            };
                
                
                //Gán giá trị cho các tham số của câu truy vấn

                para[0].Value = idbook;
            para[1].Value = idAuthor;
            result = Database.ExcuteSQL(sql, para);

            
            return result;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int idBook = Convert.ToInt32(cb_Book.SelectedValue.ToString().Trim());
            int idAuther = Convert.ToInt32(lb_Author.SelectedValue.ToString().Trim());
            if(MessageBox.Show("Do you really want to remove this author", "Confirm", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                int ck = DeleteAuthor_Book(idBook, idAuther);
                if (ck > 0)
                {
                    MessageBox.Show("Remove succefully", "Infor", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
