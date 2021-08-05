using Q3_Delete_edit.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q3_Delete_edit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static DataTable GetAllCorporation()
        {
            string sql = "select c.corp_no,c.corp_name,c.street,r.region_name from corporation as c left join region as r on c.region_no=r.region_no";
            return Database.GetDataBySQL(sql);
        }
        private static DataTable GetMemberById(int id)
        {
            string sql = "select * from member where corp_no= "+id;
            return Database.GetDataBySQL(sql);
        }
        internal static int DeleteCorporation(int id)
        {
            int result = 0;
            if (GetMemberById(id).Rows.Count > 0)
            {
                string sql = "DELETE FROM [dbo].[member] WHERE corp_no = "+id;
                Database.Execute(sql);
            }
           
                //Thực hiện xóa
                string sql1 = "DELETE FROM [dbo].[corporation] where corp_no = @id";
                SqlParameter para = new SqlParameter("@id", SqlDbType.Int);
                //Gán giá trị cho các tham số của câu truy vấn

                para.Value = id;
                result = Database.ExcuteSQL(sql1, para);

            
            return result;
        }
        private void ReFeshDgvCorporation()
        {
          
            DataGridViewCheckBoxColumn select1 = new DataGridViewCheckBoxColumn();
            select1.Name = "selectChecknox";
            select1.HeaderText = "Select";
            select1.ValueType = typeof(bool);
            dgv_Corporation.Columns.Add(select1);
            dgv_Corporation.DataSource = null;
            
            dgv_Corporation.DataSource = GetAllCorporation();
            dgv_Corporation.Columns[1].HeaderText = "Corporation No";
            dgv_Corporation.Columns[2].HeaderText = "Corporation Name";
            dgv_Corporation.Columns[3].HeaderText = "Street";
            dgv_Corporation.Columns[4].HeaderText = "Region Name";
            DataGridViewButtonColumn select2 = new DataGridViewButtonColumn();
            select2.Name = "selectButton";
            select2.HeaderText = "Edit";
            select2.Text = "Edit";
            
        
            select2.UseColumnTextForButtonValue = true;
            
            dgv_Corporation.Columns.Add(select2);

          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
            ReFeshDgvCorporation();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv_Corporation.Rows)
            {
                DataGridViewCheckBoxCell boxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(boxCell.Value) == true)
                {
                    //dgvCategory.Rows.Remove(row);
                    int Id = Convert.ToInt32(row.Cells[1].Value.ToString());
                    count += DeleteCorporation(Id);

                }
            }
            MessageBox.Show("Deleted " + count + " corporation(s)", "Infor", MessageBoxButtons.OK);
            dgv_Corporation.AutoGenerateColumns = false;

            ReFeshDgvCorporation();
            dgv_Corporation.Columns.RemoveAt(6);
            dgv_Corporation.Columns.RemoveAt(6);





        }
        public  string name;
        public  string street;

        private void dgv_Corporation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_Corporation.RowCount; i++)
            {
                if (dgv_Corporation.Rows[i].Cells[5].Selected)
                {
                    name = dgv_Corporation.Rows[i].Cells[2].Value.ToString();
                    street = dgv_Corporation.Rows[i].Cells[3].Value.ToString();
                    Update u = new Update();
                    u.ShowDialog();
                   }

            }
   
        }
    }
    }

