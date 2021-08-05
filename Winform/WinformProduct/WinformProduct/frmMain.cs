using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformProduct
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ReFeshDgvProduct()
        {
            dvgProduct.DataSource = null;
            dvgProduct.DataSource = Product.GetProducts();
            /*dvgProduct.Columns[0].HeaderText = "Mã sản phẩm";
            dvgProduct.Columns[1].HeaderText = "Tên ản phẩm";
            dvgProduct.Columns[2].HeaderText = "Giá sản phẩm";
            dvgProduct.Columns[3].HeaderText = "Danh mục";*/
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ReFeshDgvProduct();
        }
    }
}
