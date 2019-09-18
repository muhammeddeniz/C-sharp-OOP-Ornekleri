using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciSayi = 0, ikinciSayi = 0, toplam = 0;
        Boolean IslemDogruMu = false;

        private int Topla(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }

        private void EkraniTemizle(TextBox birinciText, TextBox ikinciText)
        {
            birinciText.Clear();
            ikinciText.Clear();
        }

        private Boolean DogruMu()
        {
            try
            {
                birinciSayi = Convert.ToInt32(textBox1.Text);
                ikinciSayi = Convert.ToInt32(textBox2.Text);

                return true;
                   
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {

            if (DogruMu())
            {
                toplam = Topla(birinciSayi, ikinciSayi);
                label4.Text = toplam.ToString();

                EkraniTemizle(textBox1, textBox2);
            }
            else
            {
                MessageBox.Show("Hatalı işlem Yaptınız");
            }
            
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
