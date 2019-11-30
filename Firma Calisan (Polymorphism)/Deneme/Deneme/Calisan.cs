using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Calisan
    {
        public string İsim { get; set; }
        public decimal Maas { get; set; }
        private int asgariUcret = 2000;
        public int calisilanGun { get; set; }

        public virtual decimal MaasHesapla()
        {
            Maas = asgariUcret * 2;
            return Maas;
        }
    }
}
