using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_Uygulamasi
{
    public class Fabrika
    {
        public string isim { get; set; }
        public string adres { get; set; }
        public List<Personel> personeller { get; set; }

        string deger = "";
        public void iseAlim(Personel p)
        {
            personeller.Add(p);
        }
        public string personelLİstele()
        {
            
            foreach (var item in personeller)
            {
                deger += "Personel No: " + item.personelNo;
                deger += " Ad : " + item.kimlik.ad;
                deger += " Soyad : " + item.kimlik.soyad;
                deger += " Birim:" + item.birim + "\n";
            }
            return deger;
        }
        public void istenCikarma(Personel p)
        {
            personeller.Remove(p);
        }

    }
}
