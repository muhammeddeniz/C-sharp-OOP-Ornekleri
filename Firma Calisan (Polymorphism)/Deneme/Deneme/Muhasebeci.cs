using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Muhasebeci : Calisan
    {
        public int toplamCalisma { get; set; }

        public override decimal MaasHesapla()
        {
            base.MaasHesapla();
            int mesai = toplamCalisma - calisilanGun;
            Maas += (Maas / 21) * mesai;
            return Maas;

        }
    }
}
