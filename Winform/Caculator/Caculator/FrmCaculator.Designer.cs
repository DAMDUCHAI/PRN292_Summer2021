
namespace Caculator
{
    partial class FrmCaculator
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
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.rbsub = new System.Windows.Forms.RadioButton();
            this.rbmul = new System.Windows.Forms.RadioButton();
            this.rbdiv = new System.Windows.Forms.RadioButton();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number first";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(244, 81);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(126, 20);
            this.txtfirst.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caculator";
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(244, 139);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(126, 20);
            this.txtsecond.TabIndex = 4;
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(96, 230);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(75, 23);
            this.btnresult.TabIndex = 5;
            this.btnresult.Text = "Result";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // rbadd
            // 
            this.rbadd.AutoSize = true;
            this.rbadd.Location = new System.Drawing.Point(121, 173);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(31, 17);
            this.rbadd.TabIndex = 6;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "+";
            this.rbadd.UseVisualStyleBackColor = true;
            // 
            // rbsub
            // 
            this.rbsub.AutoSize = true;
            this.rbsub.Location = new System.Drawing.Point(198, 173);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(28, 17);
            this.rbsub.TabIndex = 7;
            this.rbsub.TabStop = true;
            this.rbsub.Text = "-";
            this.rbsub.UseVisualStyleBackColor = true;
            // 
            // rbmul
            // 
            this.rbmul.AutoSize = true;
            this.rbmul.Location = new System.Drawing.Point(268, 173);
            this.rbmul.Name = "rbmul";
            this.rbmul.Size = new System.Drawing.Size(30, 17);
            this.rbmul.TabIndex = 8;
            this.rbmul.TabStop = true;
            this.rbmul.Text = "x";
            this.rbmul.UseVisualStyleBackColor = true;
            this.rbmul.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbdiv
            // 
            this.rbdiv.AutoSize = true;
            this.rbdiv.Location = new System.Drawing.Point(347, 173);
            this.rbdiv.Name = "rbdiv";
            this.rbdiv.Size = new System.Drawing.Size(30, 17);
            this.rbdiv.TabIndex = 9;
            this.rbdiv.TabStop = true;
            this.rbdiv.Text = "/";
            this.rbdiv.UseVisualStyleBackColor = true;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(244, 233);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(126, 20);
            this.txtresult.TabIndex = 10;
            // 
            // FrmCaculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 307);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.rbdiv);
            this.Controls.Add(this.rbmul);
            this.Controls.Add(this.rbsub);
            this.Controls.Add(this.rbadd);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCaculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.RadioButton rbsub;
        private System.Windows.Forms.RadioButton rbmul;
        private System.Windows.Forms.RadioButton rbdiv;
        private System.Windows.Forms.TextBox txtresult;
    }
}

