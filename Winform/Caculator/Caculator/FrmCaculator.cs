using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caculator
{
    public partial class FrmCaculator : Form
    {
        public FrmCaculator()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        public bool check(string s1, string s2)
        {
            try
            {
                double txt1 = Double.Parse(s1);
                double txt2 = Double.Parse(s2);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            string txtFirst = txtfirst.Text;
            string txtSrcond = txtsecond.Text;
            bool kt = check(txtFirst, txtSrcond);
            if (!rbadd.Checked && !rbsub.Checked && !rbmul.Checked && !rbdiv.Checked)
            {
                MessageBox.Show("You need choose radiobuton above!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kt == false)
            {
                MessageBox.Show("Can't enter string", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            {
                
           
                double txt1 = Double.Parse(txtFirst);
                double txt2 = Double.Parse(txtSrcond);
                if (rbadd.Checked)
                {
                    double result = txt1 + txt2;
                    txtresult.Text = result.ToString();
                }
                if (rbsub.Checked)
                {
                 
                    double result = txt1 - txt2;
                    txtresult.Text = result.ToString();
                }
                if (rbmul.Checked)
                {
                    double result = txt1 * txt2;
                    txtresult.Text = result.ToString();
                }
                if (rbdiv.Checked)
                {
                    if (txt2 == 0)
                    {
                        MessageBox.Show("Can't divide for 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    double result = txt1 / txt2;
                    txtresult.Text = result.ToString();
                }
            }
        }

        private void FrmCaculator_Load(object sender, EventArgs e)
        {

        }
    }
}
