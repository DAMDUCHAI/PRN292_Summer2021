using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace systemLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool ValidateAcount()
        {
            //Kiem tra user hoac pass la rong
            if (txtpass.Text.Trim() =="" ||  txtuser.Text.Trim() == "")
            {
                return false;
            }
            //Kiem tra du lieu co nguy co SQL Injection
            Regex regex = new Regex(@"^([a-zA-Z0-9\.\@_]+)$");
            if (!regex.IsMatch(txtpass.Text.Trim()))
            {
                return false;
            }
            if (!regex.IsMatch(txtuser.Text.Trim()))
            {
                return false;
            }

            return true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // gia su user = sa , pass = 123
            string user = txtuser.Text.Trim();
            string pass = txtpass.Text.Trim();
            if (ValidateAcount())
            {
                if(user.Equals("sa") && pass.Equals("123"))
                {
                    new frmMain().Show();

                }
                else
                {
                    MessageBox.Show("This acount not exits !", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Invalid Acount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
