using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_Uygulamasi
{
    public class Personel
    {
        public Kimlik_Bilgileri kimlik { get; set; } = new Kimlik_Bilgileri();
        public int personelNo { get; private set; }
        public string birim { get; set; }

        public Personel(int personelNo)
        {
            this.personelNo = personelNo;
        }

    }
}
