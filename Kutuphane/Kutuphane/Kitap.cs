using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public abstract class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime BasimYili { get; set; }
        public bool RaftaMi { get; set; }
        public string Kategori { get; set; }
    }
}
