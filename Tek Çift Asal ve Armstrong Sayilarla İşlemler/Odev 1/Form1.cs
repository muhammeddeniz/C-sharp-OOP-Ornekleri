using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        ulong ciftToplam = 0, tekToplam = 0, asalToplam = 0, armstrongToplam = 0;


        List<ulong> ciftSayilar = new List<ulong>();
        List<ulong> tekSayilar = new List<ulong>();
        List<ulong> asalSayilar = new List<ulong>();
        List<ulong> armstrongSayilar = new List<ulong>();

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            int index = tabIslemler.SelectedIndex;
            if (index > 0)
            {
                tabIslemler.SelectedIndex = index - 1;
            }

        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            int index = tabIslemler.SelectedIndex;
            if (index < 4)
            {
                tabIslemler.SelectedIndex = index + 1;
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            ListboxTemizle(listAsal, listArmstrong, listTek, listCift);

            txtArmstrngToplam.Clear();
            txtAsaltoplam.Clear();
            txtCiftToplam.Clear();
            txtTekToplam.Clear();

            tekToplam = 0;
            ciftToplam = 0;
            asalToplam = 0;
            armstrongToplam = 0;
            
            ciftSayilar.Clear();
            tekSayilar.Clear();
            armstrongSayilar.Clear();
            asalSayilar.Clear();

            ulong baslangicDegeri = Convert.ToUInt64(txtBaslangic.Text);
            ulong bitisDegeri = Convert.ToUInt64(txtBitis.Text);

            if (baslangicDegeri < bitisDegeri)
            {
                SonucDon(tabIslemler, baslangicDegeri, bitisDegeri);
            }
            else
            {
                MessageBox.Show("Hatalı Degerler Girdiniz.");
                txtBaslangic.Clear();
                txtBitis.Clear();
            }

            string fileName = @"C:\Users\Muhammed\Desktop\Tek Çift Asal ve Armstrong Sayilarla İşlemler\Log.txt";
            string writeText = "Log";

            if (tabIslemler.SelectedTab == tabTekSayilar)
            {
                writeText = DateTime.Now.ToString() + "   Tek Sayılar İşlemi\n" + "Tek Toplam : " + tekToplam+"\n Bu Aralıktaki Tek Sayilar : ";
                foreach (var item in tekSayilar)
                {
                    writeText += item + ", ";
                }
                writeText += "\n";
            }
            if (tabIslemler.SelectedTab == tabCiftSayilar)
            {
                writeText = DateTime.Now.ToString() +"   Çift Sayılar İşlemi\n"+ "Cift Toplam : " + ciftToplam + "\n Bu Aralıktaki Cift Sayilar : ";
                foreach (var item in ciftSayilar)
                {
                    writeText += item + ", ";
                }
                writeText += "\n";
            }
            if (tabIslemler.SelectedTab == tabAsal)
            {
                writeText = DateTime.Now.ToString() + "   Asal Sayılar İşlemi\n" + "Asal Toplam : " + asalToplam + "\n Bu Aralıktaki Asal Sayilar : ";
                foreach (var item in asalSayilar)
                {
                    writeText += item + ", ";
                }
                writeText += "\n";
            }
            if (tabIslemler.SelectedTab == tabArmstrong)
            {
                writeText = DateTime.Now.ToString() + "   Armstrong Sayılar İşlemi\n" + "Armstrong Toplam : " + armstrongToplam + "\n Bu Aralıktaki Armstrong Sayilar : ";
                foreach (var item in armstrongSayilar)
                {
                    writeText += item + ", ";
                }
                writeText += "\n";
            }


            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName, Environment.NewLine + writeText);
          
        }


        private ulong ArmstrongSayi(ulong sayi)
        {
            ulong islem = 0, sonuc = 0, temp = 0;
            temp = sayi;
            while (sayi > 0)
            {
                islem = sayi % 10;
                sonuc += (islem * islem * islem);
                sayi /= 10;
            }

            return (temp == sonuc) ? temp : 0;
        }
        private ulong AsalSayi(ulong sayi)
        {
            for (ulong j = 2; j < sayi; j++)
            {
                if (sayi % j == 0)
                {
                    return 0;
                }
            }
            return sayi;
        }

        private void ListboxTemizle(ListBox lst, ListBox lst2, ListBox lst3, ListBox lst4)
        {
            lst.Items.Clear();
            lst2.Items.Clear();
            lst3.Items.Clear();
            lst4.Items.Clear();
        }
       
        private ulong SonucDon(TabControl tab, ulong baslangic, ulong bitis)
        {
          
            for (ulong i = baslangic; i < bitis; i++)
            {
                if (i%2==0)
                {
                    ciftToplam += i;
                    ciftSayilar.Add(i);
                }
                else
                {
                    tekToplam += i;
                    tekSayilar.Add(i); 
                }
                if (ArmstrongSayi(i) != 0)
                {
                    armstrongToplam += i;
                    armstrongSayilar.Add(i);
                }
                if (AsalSayi(i) != 0)
                {
                    asalToplam += i;
                    asalSayilar.Add(i);
                }
            }


            if (tab.SelectedTab == tabTekSayilar)
            {
                foreach (var item in tekSayilar)
                {
                    listTek.Items.Add(item);
                }
                txtTekToplam.Text = tekToplam.ToString();
                return tekToplam;
            }

            else if (tab.SelectedTab == tabCiftSayilar)
            {
                foreach (var item in ciftSayilar)
                {
                    listCift.Items.Add(item);
                }
                txtCiftToplam.Text = ciftToplam.ToString();
                return ciftToplam;
            }

            else if (tab.SelectedTab == tabAsal)
            {
                foreach (var item in asalSayilar)
                {
                    listAsal.Items.Add(item);
                }
                txtAsaltoplam.Text = asalToplam.ToString();
                return asalToplam;
            }

            else if (tab.SelectedTab == tabArmstrong)
            {
                foreach (var item in armstrongSayilar)
                {
                    listArmstrong.Items.Add(item);
                }

                txtArmstrngToplam.Text = armstrongToplam.ToString();
                return armstrongToplam;
            }
            return 0;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(2000, "Hesap Uygulaması", "Hoş Geldiniz ", ToolTipIcon.Info);
            txtBaslangic.Text = "1";
            txtBitis.Text = "10000";
        }
    }
}
