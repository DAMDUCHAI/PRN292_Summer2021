using EditShip.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btSave.Enabled = false;
            btSearch.Enabled = true;
            List<string> listClass = DAO.Ship.GetClass();
            foreach(string s in listClass)
            {
                cbClass.Items.Add(s);
            }
            cbClass.SelectedIndex = 0;

        }

        private void brSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name requied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Ship> listShip = DAO.Ship.SearchShip(txtName.Text);
            if (listShip.Count == 0)
            {
                MessageBox.Show("This ship is not existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txtLaunched.Text = listShip[0].Launched.ToString();
            cbClass.Text= listShip[0].Classs.ToString();

            btSave.Enabled = true;
            btSearch.Enabled = false;



        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string classs = cbClass.Text;
            int launched = int.Parse(txtLaunched.Text);
            ArrayList s = new ArrayList() { name, classs, launched };
            int check = DAO.Ship.UpdateShip(s);
            if (check > 0)
            {
                MessageBox.Show("This ship is saved!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSave.Enabled = false;
                btSearch.Enabled = true;
                txtName.Text = "";
                txtLaunched.Text = "";
                cbClass.SelectedIndex = 0;
                return;
            }

        }
    }
}
