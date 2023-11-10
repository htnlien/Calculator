namespace Calculator
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
            this.lbTinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.lbKQ = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.lba = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTinh
            // 
            this.lbTinh.AutoSize = true;
            this.lbTinh.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTinh.Location = new System.Drawing.Point(332, 50);
            this.lbTinh.Name = "lbTinh";
            this.lbTinh.Size = new System.Drawing.Size(62, 16);
            this.lbTinh.TabIndex = 0;
            this.lbTinh.Text = "Tính toán";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btCong
            // 
            this.btCong.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btCong.Location = new System.Drawing.Point(425, 275);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 3;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbKQ.Location = new System.Drawing.Point(127, 262);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(51, 16);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = "kết quả";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbb.Location = new System.Drawing.Point(127, 200);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(35, 16);
            this.lbb.TabIndex = 0;
            this.lbb.Text = "Số b";
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lba.Location = new System.Drawing.Point(127, 134);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(35, 16);
            this.lba.TabIndex = 0;
            this.lba.Text = "Số a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(227, 134);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(227, 262);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 22);
            this.txtKQ.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(227, 200);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbTinh);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtB;
    }
}

