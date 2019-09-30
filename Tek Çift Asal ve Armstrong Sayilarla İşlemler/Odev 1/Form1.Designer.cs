namespace Odev_1
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.tabIslemler = new System.Windows.Forms.TabControl();
            this.tabTekSayilar = new System.Windows.Forms.TabPage();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.lblTekToplam = new System.Windows.Forms.Label();
            this.listTek = new System.Windows.Forms.ListBox();
            this.tabCiftSayilar = new System.Windows.Forms.TabPage();
            this.txtCiftToplam = new System.Windows.Forms.TextBox();
            this.lblCiftToplam = new System.Windows.Forms.Label();
            this.listCift = new System.Windows.Forms.ListBox();
            this.tabAsal = new System.Windows.Forms.TabPage();
            this.txtAsaltoplam = new System.Windows.Forms.TextBox();
            this.lblAsalToplam = new System.Windows.Forms.Label();
            this.listAsal = new System.Windows.Forms.ListBox();
            this.tabArmstrong = new System.Windows.Forms.TabPage();
            this.txtArmstrngToplam = new System.Windows.Forms.TextBox();
            this.lblArmstrngToplam = new System.Windows.Forms.Label();
            this.listArmstrong = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.txtBitis = new System.Windows.Forms.MaskedTextBox();
            this.tabIslemler.SuspendLayout();
            this.tabTekSayilar.SuspendLayout();
            this.tabCiftSayilar.SuspendLayout();
            this.tabAsal.SuspendLayout();
            this.tabArmstrong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIslemler
            // 
            this.tabIslemler.Controls.Add(this.tabTekSayilar);
            this.tabIslemler.Controls.Add(this.tabCiftSayilar);
            this.tabIslemler.Controls.Add(this.tabAsal);
            this.tabIslemler.Controls.Add(this.tabArmstrong);
            this.tabIslemler.Location = new System.Drawing.Point(12, 164);
            this.tabIslemler.Name = "tabIslemler";
            this.tabIslemler.SelectedIndex = 0;
            this.tabIslemler.Size = new System.Drawing.Size(825, 486);
            this.tabIslemler.TabIndex = 0;
            // 
            // tabTekSayilar
            // 
            this.tabTekSayilar.Controls.Add(this.txtTekToplam);
            this.tabTekSayilar.Controls.Add(this.lblTekToplam);
            this.tabTekSayilar.Controls.Add(this.listTek);
            this.tabTekSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabTekSayilar.Name = "tabTekSayilar";
            this.tabTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayilar.Size = new System.Drawing.Size(817, 457);
            this.tabTekSayilar.TabIndex = 0;
            this.tabTekSayilar.Text = "Tek Sayılar";
            this.tabTekSayilar.UseVisualStyleBackColor = true;
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Enabled = false;
            this.txtTekToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTekToplam.Location = new System.Drawing.Point(499, 168);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.Size = new System.Drawing.Size(170, 26);
            this.txtTekToplam.TabIndex = 4;
            // 
            // lblTekToplam
            // 
            this.lblTekToplam.AutoSize = true;
            this.lblTekToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTekToplam.Location = new System.Drawing.Point(495, 123);
            this.lblTekToplam.Name = "lblTekToplam";
            this.lblTekToplam.Size = new System.Drawing.Size(179, 20);
            this.lblTekToplam.TabIndex = 3;
            this.lblTekToplam.Text = "Tek Sayilarin Toplamı :";
            // 
            // listTek
            // 
            this.listTek.FormattingEnabled = true;
            this.listTek.ItemHeight = 16;
            this.listTek.Location = new System.Drawing.Point(6, 6);
            this.listTek.MultiColumn = true;
            this.listTek.Name = "listTek";
            this.listTek.Size = new System.Drawing.Size(404, 436);
            this.listTek.TabIndex = 0;
            // 
            // tabCiftSayilar
            // 
            this.tabCiftSayilar.Controls.Add(this.txtCiftToplam);
            this.tabCiftSayilar.Controls.Add(this.lblCiftToplam);
            this.tabCiftSayilar.Controls.Add(this.listCift);
            this.tabCiftSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabCiftSayilar.Name = "tabCiftSayilar";
            this.tabCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayilar.Size = new System.Drawing.Size(817, 457);
            this.tabCiftSayilar.TabIndex = 1;
            this.tabCiftSayilar.Text = "Çift Sayılar";
            this.tabCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // txtCiftToplam
            // 
            this.txtCiftToplam.Enabled = false;
            this.txtCiftToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiftToplam.Location = new System.Drawing.Point(513, 194);
            this.txtCiftToplam.Name = "txtCiftToplam";
            this.txtCiftToplam.Size = new System.Drawing.Size(170, 26);
            this.txtCiftToplam.TabIndex = 6;
            // 
            // lblCiftToplam
            // 
            this.lblCiftToplam.AutoSize = true;
            this.lblCiftToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiftToplam.Location = new System.Drawing.Point(509, 149);
            this.lblCiftToplam.Name = "lblCiftToplam";
            this.lblCiftToplam.Size = new System.Drawing.Size(178, 20);
            this.lblCiftToplam.TabIndex = 5;
            this.lblCiftToplam.Text = "Çift Sayilarin Toplamı :";
            // 
            // listCift
            // 
            this.listCift.FormattingEnabled = true;
            this.listCift.ItemHeight = 16;
            this.listCift.Location = new System.Drawing.Point(6, 6);
            this.listCift.MultiColumn = true;
            this.listCift.Name = "listCift";
            this.listCift.Size = new System.Drawing.Size(404, 436);
            this.listCift.TabIndex = 1;
            // 
            // tabAsal
            // 
            this.tabAsal.Controls.Add(this.txtAsaltoplam);
            this.tabAsal.Controls.Add(this.lblAsalToplam);
            this.tabAsal.Controls.Add(this.listAsal);
            this.tabAsal.Location = new System.Drawing.Point(4, 25);
            this.tabAsal.Name = "tabAsal";
            this.tabAsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsal.Size = new System.Drawing.Size(817, 457);
            this.tabAsal.TabIndex = 2;
            this.tabAsal.Text = "Asal Sayılar";
            this.tabAsal.UseVisualStyleBackColor = true;
            // 
            // txtAsaltoplam
            // 
            this.txtAsaltoplam.Enabled = false;
            this.txtAsaltoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsaltoplam.Location = new System.Drawing.Point(530, 170);
            this.txtAsaltoplam.Name = "txtAsaltoplam";
            this.txtAsaltoplam.Size = new System.Drawing.Size(170, 26);
            this.txtAsaltoplam.TabIndex = 6;
            // 
            // lblAsalToplam
            // 
            this.lblAsalToplam.AutoSize = true;
            this.lblAsalToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsalToplam.Location = new System.Drawing.Point(526, 125);
            this.lblAsalToplam.Name = "lblAsalToplam";
            this.lblAsalToplam.Size = new System.Drawing.Size(185, 20);
            this.lblAsalToplam.TabIndex = 5;
            this.lblAsalToplam.Text = "Asal Sayilarin Toplamı :";
            // 
            // listAsal
            // 
            this.listAsal.FormattingEnabled = true;
            this.listAsal.ItemHeight = 16;
            this.listAsal.Location = new System.Drawing.Point(6, 6);
            this.listAsal.MultiColumn = true;
            this.listAsal.Name = "listAsal";
            this.listAsal.Size = new System.Drawing.Size(422, 436);
            this.listAsal.TabIndex = 1;
            // 
            // tabArmstrong
            // 
            this.tabArmstrong.Controls.Add(this.txtArmstrngToplam);
            this.tabArmstrong.Controls.Add(this.lblArmstrngToplam);
            this.tabArmstrong.Controls.Add(this.listArmstrong);
            this.tabArmstrong.Location = new System.Drawing.Point(4, 25);
            this.tabArmstrong.Name = "tabArmstrong";
            this.tabArmstrong.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmstrong.Size = new System.Drawing.Size(817, 457);
            this.tabArmstrong.TabIndex = 3;
            this.tabArmstrong.Text = "Armstrong Sayılar";
            this.tabArmstrong.UseVisualStyleBackColor = true;
            // 
            // txtArmstrngToplam
            // 
            this.txtArmstrngToplam.Enabled = false;
            this.txtArmstrngToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArmstrngToplam.Location = new System.Drawing.Point(513, 180);
            this.txtArmstrngToplam.Name = "txtArmstrngToplam";
            this.txtArmstrngToplam.Size = new System.Drawing.Size(170, 26);
            this.txtArmstrngToplam.TabIndex = 6;
            // 
            // lblArmstrngToplam
            // 
            this.lblArmstrngToplam.AutoSize = true;
            this.lblArmstrngToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmstrngToplam.Location = new System.Drawing.Point(509, 135);
            this.lblArmstrngToplam.Name = "lblArmstrngToplam";
            this.lblArmstrngToplam.Size = new System.Drawing.Size(230, 20);
            this.lblArmstrngToplam.TabIndex = 5;
            this.lblArmstrngToplam.Text = "Armstrong Sayilarin Toplamı :";
            // 
            // listArmstrong
            // 
            this.listArmstrong.ItemHeight = 16;
            this.listArmstrong.Location = new System.Drawing.Point(6, 6);
            this.listArmstrong.MultiColumn = true;
            this.listArmstrong.Name = "listArmstrong";
            this.listArmstrong.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listArmstrong.Size = new System.Drawing.Size(404, 436);
            this.listArmstrong.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBitis);
            this.groupBox1.Controls.Add(this.txtBaslangic);
            this.groupBox1.Controls.Add(this.btnIleri);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.lblBitis);
            this.groupBox1.Controls.Add(this.lblBaslangic);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.Aqua;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIleri.Location = new System.Drawing.Point(681, 56);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(107, 39);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = "İLERİ >>";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Aqua;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(556, 56);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(107, 39);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "<< GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Aqua;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(342, 56);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(125, 39);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitis.Location = new System.Drawing.Point(49, 92);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(53, 20);
            this.lblBitis.TabIndex = 1;
            this.lblBitis.Text = "Bitiş :";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslangic.Location = new System.Drawing.Point(49, 44);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(93, 20);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Başlangıç :";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(181, 41);
            this.txtBaslangic.Mask = "00000";
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.txtBaslangic.TabIndex = 7;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(181, 89);
            this.txtBitis.Mask = "00000";
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 22);
            this.txtBitis.TabIndex = 8;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(849, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabIslemler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "İŞLEMLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabIslemler.ResumeLayout(false);
            this.tabTekSayilar.ResumeLayout(false);
            this.tabTekSayilar.PerformLayout();
            this.tabCiftSayilar.ResumeLayout(false);
            this.tabCiftSayilar.PerformLayout();
            this.tabAsal.ResumeLayout(false);
            this.tabAsal.PerformLayout();
            this.tabArmstrong.ResumeLayout(false);
            this.tabArmstrong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIslemler;
        private System.Windows.Forms.TabPage tabTekSayilar;
        private System.Windows.Forms.ListBox listTek;
        private System.Windows.Forms.TabPage tabCiftSayilar;
        private System.Windows.Forms.ListBox listCift;
        private System.Windows.Forms.TabPage tabAsal;
        private System.Windows.Forms.ListBox listAsal;
        private System.Windows.Forms.TabPage tabArmstrong;
        private System.Windows.Forms.ListBox listArmstrong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtTekToplam;
        private System.Windows.Forms.Label lblTekToplam;
        private System.Windows.Forms.TextBox txtCiftToplam;
        private System.Windows.Forms.Label lblCiftToplam;
        private System.Windows.Forms.TextBox txtAsaltoplam;
        private System.Windows.Forms.Label lblAsalToplam;
        private System.Windows.Forms.TextBox txtArmstrngToplam;
        private System.Windows.Forms.Label lblArmstrngToplam;
        private System.Windows.Forms.MaskedTextBox txtBitis;
        private System.Windows.Forms.MaskedTextBox txtBaslangic;
    }
}

