using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Satisci:Calisan
    {
        public int satısMiktari { get; set; }

        public override decimal MaasHesapla()
        {
            base.MaasHesapla();
            Maas += satısMiktari*1.10M;
            return Maas;
        }
    }
}

