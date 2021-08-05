using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbque.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbnam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string result = "", hoten,ngoaingu="";
            hoten = txtho.Text + " " + txtten.Text;
            if (rbnam.Checked)
            {
                result = "Xin chào Mr " + hoten;
            }
            else
            {
                result = "Xin chào Mss " + hoten;
            }

            if (cktviet.Checked)
            {
                ngoaingu = "Tiếng Việt";
            }
            if (ckanh.Checked)
            {

                ngoaingu = (ngoaingu.Length == 0) ? "Tiếng Anh" : (ngoaingu + " , Tiếng Anh");
            }
            result += "\n Ngoại ngữ: " + ngoaingu;

            if(cbque.SelectedIndex >= 0)
            {
                result += "\n Quê quán " + cbque.Text;
            }
            MessageBox.Show(result);
            ngoaingu = "";

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtho.Text = "";
            txtten.Text = "";
            cbque.SelectedIndex = 0;
            rbnam.Checked = false;
            rbnu.Checked = false;
            ckanh.Checked = false;
            cktviet.Checked = false;
            

        }
    }
}
