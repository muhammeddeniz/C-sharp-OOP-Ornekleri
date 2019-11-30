using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Firma
    {
        public string FirmaAdi { get; set; }

        public List<Calisan> calisanlar { get; set; } = new List<Calisan>();

        public void calisanEkle(Calisan c)
        {
            calisanlar.Add(c);
        }

        public void calisanCikar(Calisan c)
        {
            calisanlar.Remove(c);
        }
       public string CalisanlarListele()
        {
            string kisiler = "";

            foreach (var item in calisanlar)
            { kisiler += item.ToString(); }

            return kisiler;
        }

        decimal maaslar;
        public decimal ToplamMaas()
        {
            foreach (var item in calisanlar)
            {
                maaslar += item.MaasHesapla();
            }

            return maaslar;
        }
    }
}
