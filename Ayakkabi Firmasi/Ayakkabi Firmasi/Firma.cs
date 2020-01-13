using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabi_Firmasi
{
    public abstract class Firma
    {
        public List<Urun> Urunler { get; set; }
        public Mudur FirmaMuduru { get; set; }
        public List<StandartCalisan> Calisanlar { get; set;  }
        public List<Ayakkabi> Ayakkabilar { get; set; }

        public Firma()
        {
            Urunler = new List<Urun>();
            FirmaMuduru = new Mudur();
            Calisanlar = new List<StandartCalisan>();
            Ayakkabilar = new List<Ayakkabi>();
        }


        public void UrunEkle(Urun u)
        {
            Urunler.Add(u);
        }
        public void UrunCikar(Urun u)
        {
            Urunler.Remove(u);
        }
        public string UrunleriListele()
        {
            string urunler = "";

            foreach (Urun u in Urunler)
            {
                urunler += "Urun Numarası : " + u.UrunNo + "Urun Adi : " + u.Adi + "Urun Fiyatı : " + u.Fiyat;
            }

            return urunler;
        }

        public void CalisanEkle(StandartCalisan c)
        {
            Calisanlar.Add(c);
        }
        public void CalisanCikar(StandartCalisan c)
        {
            Calisanlar.Remove(c);
        }
        public string CalisanlariListele()
        {
            string calisanlar = "";
            foreach (StandartCalisan c in Calisanlar)
            {
                calisanlar += c.isim + " " + c.maas + " " + c.numara + " " + c.yas;
            }

            return calisanlar;
        }

    }
}
