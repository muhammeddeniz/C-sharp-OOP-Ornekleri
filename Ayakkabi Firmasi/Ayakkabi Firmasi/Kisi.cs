using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabi_Firmasi
{
    public abstract class Kisi
    {
        public string isim { get; set; }
        public int yas { get; set; }
        public int numara { get; set; }
        public int maas { get; protected set; }
        
        private int ASGARIUCRET = 2000;

        public virtual void MaasHesapla()
        {
            this.maas = ASGARIUCRET;
        }

    }
}
