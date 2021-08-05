using AddShip.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int launched;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> listName = Ship.GetNameShip();
            foreach (string n in listName)
            {
                if (n.ToString().Trim().Equals(txtName.Text.Trim()))
                {
                    MessageBox.Show("Name duplicated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!int.TryParse(txtLaunched.Text, out launched))
            {
                MessageBox.Show("Integer required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtLaunched.Text) < 1900 || int.Parse(txtLaunched.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Integer from 1900 to current year!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); MessageBox.Show("Integer from 1900 to current year!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //thuc hien add
            string name = txtName.Text;
            string classs = cbClass.Text;
            int launcheds = int.Parse(txtLaunched.Text) ;
            ArrayList arrayList = new ArrayList() { name, classs, launcheds };
            int check = Ship.AddShip(arrayList);
            if (check > 0)
            {
                MessageBox.Show("Integer from 1900 to current year!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); MessageBox.Show("A new ship is added!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> listc = Ship.GetClass();
            foreach (string s in listc)
            {
                cbClass.Items.Add(s);
            }
            cbClass.SelectedIndex = 0;


        }
    }
}
