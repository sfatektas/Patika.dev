using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi_Uygulaması
{
    class Islemler : Iislemler
    {
        private static List<Kisi> kisiler = new List<Kisi>();

        public List<Kisi> Kisiler
        {
            get
            {
                return kisiler;
            }
        }
        public void YeniNumaraEkle(string isim, string soyisim, string no)
        {
            if ((isim != "" && soyisim != "" && no != ""))
                kisiler.Add(new Kisi(isim, soyisim, no));
            else
                Console.WriteLine("Alanlar Boş Bırakılamaz.");
        }

        public void NumaralarıGoster()
        {
            foreach (var item in kisiler)
            {
                Console.WriteLine("\nİsim : {0}", item.Isim);
                Console.WriteLine("Soyisim : {0}", item.Soyisim);
                Console.WriteLine("Telefon No: {0}", item.TelNo);
                Console.WriteLine("\n*****************************");
            }
        }

        public bool NumarayiGuncelle(string girdi, string numara)
        {
            foreach (var item in kisiler)
            {
                if (girdi == item.Isim || girdi == item.Soyisim)
                {
                    item.TelNo = numara;
                    return true;
                }
            }
            return false;
        }

        public bool NumarayiSil(string girdi)
        {
            foreach (var item in kisiler)
            {
                if (girdi == item.TelNo)
                {
                    kisiler.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool RehberdeArama(string girdi)
        {
            foreach (var item in kisiler)
            {
                if (girdi == item.Isim || girdi == item.Soyisim || girdi == item.TelNo)
                {
                    Console.WriteLine("\nİsim : {0}", item.Isim);
                    Console.WriteLine("Soyisim : {0}", item.Soyisim);
                    Console.WriteLine("Telefon No: {0}", item.TelNo);
                    Console.WriteLine("\n*****************************");
                    return true;
                }
            }
            return false;
        }

        public bool NumaraVarMı(string girdi)
        {
            foreach (var item in kisiler)
            {
                if (girdi == item.Isim)
                {
                    return true;
                }
                else if (girdi == item.Soyisim)
                {
                    return true;
                }
                else if (girdi == item.TelNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
