using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi_Uygulaması
{
    public interface Iislemler
    {
        public void YeniNumaraEkle(string isim, string soyisim, string no);
        public bool NumarayiSil(string girdi);
        public bool NumarayiGuncelle(string girdi,string numara);
        public bool NumaraVarMı(string girdi);
        public void NumaralarıGoster();
        public bool RehberdeArama(string girdi);
    }
}
