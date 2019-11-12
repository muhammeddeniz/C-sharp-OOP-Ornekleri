using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fabrika f1 = new Fabrika();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int personelNo = int.Parse(txtPersonelNo.Text);
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string birim = txtBirim.Text;

            f1.isim = "Deniz";
            f1.adres = "9123 sk no 19";
            f1.personeller = new List<Personel>();
            Personel p1 = new Personel(personelNo);
            p1.birim = birim;
            p1.kimlik.ad = ad;
            p1.kimlik.soyad = soyad;
            p1.kimlik.tcKimlikNo = 1212313;
            f1.iseAlim(p1);

        }
        private void Button2_Click(object sender, EventArgs e)
        {   
            txtListele.Text = f1.personelLİstele() + "\n" ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
