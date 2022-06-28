using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi_Uygulaması
{
    class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelNo { get; set; }

        public Kisi(string isim, string soyisim, string telno)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.TelNo = telno;
        }
    }
}
