
namespace ExampleControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtho = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.cktviet = new System.Windows.Forms.CheckBox();
            this.ckanh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.cbque = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ đệm :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtho
            // 
            this.txtho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtho.Location = new System.Drawing.Point(179, 71);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(310, 29);
            this.txtho.TabIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(179, 131);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(310, 29);
            this.txtten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính :";
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Checked = true;
            this.rbnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnam.Location = new System.Drawing.Point(179, 181);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(68, 28);
            this.rbnam.TabIndex = 5;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Nam";
            this.rbnam.UseVisualStyleBackColor = true;
            this.rbnam.CheckedChanged += new System.EventHandler(this.rbnam_CheckedChanged);
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnu.Location = new System.Drawing.Point(356, 181);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(53, 28);
            this.rbnu.TabIndex = 6;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // cktviet
            // 
            this.cktviet.AutoSize = true;
            this.cktviet.Checked = true;
            this.cktviet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cktviet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cktviet.Location = new System.Drawing.Point(179, 235);
            this.cktviet.Name = "cktviet";
            this.cktviet.Size = new System.Drawing.Size(115, 28);
            this.cktviet.TabIndex = 8;
            this.cktviet.Text = "Tiếng Việt";
            this.cktviet.UseVisualStyleBackColor = true;
            // 
            // ckanh
            // 
            this.ckanh.AutoSize = true;
            this.ckanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckanh.Location = new System.Drawing.Point(356, 235);
            this.ckanh.Name = "ckanh";
            this.ckanh.Size = new System.Drawing.Size(118, 28);
            this.ckanh.TabIndex = 9;
            this.ckanh.Text = "Tiếng Anh";
            this.ckanh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngôn ngữ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(161, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "INFORMATION USER";
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(89, 378);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(152, 31);
            this.btnview.TabIndex = 13;
            this.btnview.Text = "View infor";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(277, 378);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(152, 31);
            this.btnreset.TabIndex = 14;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // cbque
            // 
            this.cbque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbque.FormattingEnabled = true;
            this.cbque.Items.AddRange(new object[] {
            "Bắc Ninh",
            "Hà Nôi"});
            this.cbque.Location = new System.Drawing.Point(210, 299);
            this.cbque.Name = "cbque";
            this.cbque.Size = new System.Drawing.Size(121, 32);
            this.cbque.Sorted = true;
            this.cbque.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.cbque);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckanh);
            this.Controls.Add(this.cktviet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbnu);
            this.Controls.Add(this.rbnam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtho);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtho;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.CheckBox cktviet;
        private System.Windows.Forms.CheckBox ckanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox cbque;
    }
}

