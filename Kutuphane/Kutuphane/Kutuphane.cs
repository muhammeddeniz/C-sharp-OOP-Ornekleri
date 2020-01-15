using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; } 
        public List<Gorevli> Gorevliler { get; set; }
        public List<Musteri> KitapAlanlar{ get; set; }

        public Kutuphane()
        {
            this.Kitaplar = new List<Kitap>();  
            this.Gorevliler = new List<Gorevli>();
            this.KitapAlanlar = new List<Musteri>();
        }

        public void KitapEkle(Kitap k)
        {
            Kitaplar.Add(k);
        }
        public void KitapCikar(Kitap k)
        {
            Kitaplar.Remove(k);
        }
        public string KitaplariListele()
        {
            string liste = "";
            foreach (var item in Kitaplar)
            {
                liste += item.Ad + "\n";
            }

            return liste;
        }

        public void GorevliEkle(Gorevli g)
        {
            Gorevliler.Add(g);
        }
        public void GorevliCikar(Gorevli g)
        {
            Gorevliler.Remove(g);
        }
        public string GorevlileriListele()
        {
            string liste = "";
            foreach (var item in Gorevliler)
            {
                liste += item.ad + "\n";
            }

            return liste;
        }

        public void KitapAlanlaraEkle(Musteri m)
        {
            KitapAlanlar.Add(m);
        }
        public void KitapAlanlardancikar(Musteri m)
        {
            KitapAlanlar.Remove(m);
        }
        public string KitapAlanlariListele()
        {
            string liste = "";
            foreach (var item in KitapAlanlar)
            {
                liste += item.ad + "\n";
            }

            return liste;
        }

    }
}
