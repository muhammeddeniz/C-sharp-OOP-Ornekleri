using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabi_Firmasi
{
    public class StandartCalisan : Kisi
    {
        public int EnflasyonYüzdesi { get; set; }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas += (EnflasyonYüzdesi + 100) / 100;
        }
    }
}
