namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnTopla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTopla
            // 
            this.BtnTopla.BackColor = System.Drawing.Color.Aqua;
            this.BtnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopla.Location = new System.Drawing.Point(132, 243);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(172, 53);
            this.BtnTopla.TabIndex = 0;
            this.BtnTopla.Text = "TOPLA";
            this.BtnTopla.UseVisualStyleBackColor = false;
            this.BtnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(252, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(252, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 38);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birinci Sayi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci Sayi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(271, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "**";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 495);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(425, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 495);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Location = new System.Drawing.Point(9, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 10);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Location = new System.Drawing.Point(5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 10);
            this.panel4.TabIndex = 10;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCikis.Location = new System.Drawing.Point(234, 427);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(185, 53);
            this.BtnCikis.TabIndex = 11;
            this.BtnCikis.Text = "Cikis";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnTopla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.CancelButton = this.BtnCikis;
            this.ClientSize = new System.Drawing.Size(433, 496);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnTopla);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnCikis;
    }
}

