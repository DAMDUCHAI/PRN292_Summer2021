
namespace Q3_Delete_edit
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
            this.dgv_Corporation = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Corporation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Corporation
            // 
            this.dgv_Corporation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Corporation.Location = new System.Drawing.Point(24, 98);
            this.dgv_Corporation.Name = "dgv_Corporation";
            this.dgv_Corporation.Size = new System.Drawing.Size(731, 263);
            this.dgv_Corporation.TabIndex = 0;
            this.dgv_Corporation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Corporation_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(623, 47);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete Corporation";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_Corporation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Corporation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Corporation;
        private System.Windows.Forms.Button btn_delete;
    }
}

