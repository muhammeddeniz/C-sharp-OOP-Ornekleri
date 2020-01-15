using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Musteri : Kisi
    {
        public DateTime KitaiAldigiTarih { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public Kitap AldigiKitap { get; set; }
    }
}
