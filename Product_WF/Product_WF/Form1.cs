using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Product_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ReFeshDgvProduct()
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = Product.GetProducts();
  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReFeshDgvProduct();
        }
    }
}
