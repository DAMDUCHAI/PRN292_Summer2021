using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunnyButton
{
    public partial class FunnyButton : Form
    {
        public FunnyButton()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLabel.Text))
            {
                MessageBox.Show("Label of the button cannot be blank ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Button b = new Button();
            b.Text = txtLabel.Text;
            b.BackColor = txtColor.BackColor;
            flowLayoutPanel.Controls.Add(b);

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = txtColor.ForeColor;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                txtColor.BackColor = MyDialog.Color;

        }
        bool check = false;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                txtId.Text = "HE141462";
                return;
            }
            if (string.IsNullOrEmpty(txtLabel.Text))
            {
                MessageBox.Show("Label of the button cannot be blank ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = "Label:"+txtLabel.Text;
            Color c = txtColor.BackColor;
            string rgb = "Color: RGB("+ c.R + "," + c.G + "," + c.B + ")";
           result +="\n" + rgb;
                MessageBox.Show(result,"",MessageBoxButtons.OK);

            
        }
    }
}
