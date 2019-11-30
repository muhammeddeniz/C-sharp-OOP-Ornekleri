using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Firma DeepBlue = new Firma();
            Calisan c1 = new Calisan();
            c1.İsim = "Veli Gümüş";
            c1.calisilanGun = 21;

            Muhasebeci m1 = new Muhasebeci();
            m1.İsim = "Ahmet Demir";
            m1.calisilanGun = 21;
            m1.calisilanGun = 21;
            m1.toplamCalisma = 24;

            Satisci s1 = new Satisci();
            s1.İsim = "Mehmet Celik";
            s1.satısMiktari = 1000;

            MessageBox.Show(s1.İsim + s1.MaasHesapla().ToString());
            MessageBox.Show(m1.İsim + m1.MaasHesapla().ToString());
            MessageBox.Show(c1.İsim + c1.MaasHesapla().ToString());

            DeepBlue.calisanEkle(m1);
            DeepBlue.calisanEkle(s1);
            DeepBlue.calisanEkle(c1);

            MessageBox.Show("Maaslar Toplamı : " + DeepBlue.ToplamMaas().ToString());
        }
    }
}
