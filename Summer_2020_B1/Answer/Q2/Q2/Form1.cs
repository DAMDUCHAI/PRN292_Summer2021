using Q2.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
            DataTable dataTable = Database.GetDataBySQL("select * from Subjects");
            cb_Subject.DataSource = dataTable;
            cb_Subject.DisplayMember = "SubjectName";
            cb_Subject.ValueMember = "SubjectId";

            //xu li listBox
            DataTable dataTable1 = Database.GetDataBySQL("select InstructorId,(InstructorFirstName + InstructorMidName + InstructorLastName) as Name from Instructors");
            lb_Intructor.DataSource = dataTable1;
            lb_Intructor.DisplayMember = "Name";
            lb_Intructor.ValueMember = "InstructorId";

        }
        public bool checkCode(string s)
        {
            Regex reg = new Regex(@"[a-zA-z|0-9|-]+$");
            if (reg.IsMatch(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            if (checkCode(txt_Code.Text.Trim()) == false)
            {
                MessageBox.Show("Incorect code !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Code.Text = "";
                txt_Code.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Description.Text))
            {
                MessageBox.Show("Empty Description !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Description.Focus();
                return;
            }
            string code = txt_Code.Text.Trim();
            string dis = txt_Description.Text.Trim();
            int sub = Convert.ToInt32(cb_Subject.SelectedValue.ToString());
            int instru = Convert.ToInt32(lb_Intructor.SelectedValue.ToString());

            ArrayList arr = new ArrayList() {code,dis,sub,instru};
            Courses c = new Courses();
            int check = c.AddCourse(arr);
            if (check > 0)
            {
                MessageBox.Show("Add Succesfully !", "Infor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void cb_Subject_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }
    }
}
