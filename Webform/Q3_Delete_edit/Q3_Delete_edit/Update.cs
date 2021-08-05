using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q3_Delete_edit
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
       
        private void Update_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            txt_Name.Text = f.name;
            txt_Street.Text = f.name;
        }
    }
}
