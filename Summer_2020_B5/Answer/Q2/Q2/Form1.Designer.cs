
namespace Q2
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
            this.cb_Book = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lb_Author = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cb_Book
            // 
            this.cb_Book.FormattingEnabled = true;
            this.cb_Book.Location = new System.Drawing.Point(190, 44);
            this.cb_Book.Name = "cb_Book";
            this.cb_Book.Size = new System.Drawing.Size(121, 21);
            this.cb_Book.TabIndex = 0;
            this.cb_Book.SelectedValueChanged += new System.EventHandler(this.cb_Book_SelectedValueChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Location = new System.Drawing.Point(190, 100);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(121, 21);
            this.cb_Year.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(105, 315);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(195, 23);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove Selected Author";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lb_Author
            // 
            this.lb_Author.FormattingEnabled = true;
            this.lb_Author.Location = new System.Drawing.Point(190, 180);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(120, 95);
            this.lb_Author.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 367);
            this.Controls.Add(this.lb_Author);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Year);
            this.Controls.Add(this.cb_Book);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Book;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.ListBox lb_Author;
    }
}

