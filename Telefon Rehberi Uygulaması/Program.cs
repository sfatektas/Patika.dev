using System;
using System.Collections.Generic;

namespace Telefon_Rehberi_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            App newapp = new();
        }
    }
    class App
    {
        Islemler islem = new Islemler();
        public App()
        {
            AnaMenu();
        }
        public void AnaMenu()
        {
            try
            {
                string secim;
                Console.Clear();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine(" *******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak﻿ \n(6) Çıkış ");
                secim = Console.ReadLine().ToString();
                Secim(Convert.ToInt32(secim));
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen geçerli bir girdi giriniz.");
                Console.ReadKey();
                AnaMenu();
            }

        }
        public void Secim(int secim)
        {
            switch (secim)
            {
                case 1:
                    {
                        string _secim;
                        do
                        {
                            Console.Clear();
                            string isim, soyisim, no;
                            Console.WriteLine("Lütfen isim giriniz: ");
                            isim = Console.ReadLine();
                            Console.WriteLine("Lütfen soyisim giriniz: ");
                            soyisim = Console.ReadLine();
                            Console.WriteLine("Lütfen TelNo giriniz: ");
                            no = Console.ReadLine();
                            islem.YeniNumaraEkle(isim, soyisim, no);
                            Console.WriteLine("Yeni bir kayıt eklemek istiyor musunuz ? (e/h)");
                            _secim = Console.ReadLine();

                        } while (_secim == "e"|| _secim == "E");
                            AnaMenu();
                    }
                    break;
                case 2:
                    {
                        string _secim;
                        do
                        {
                            Console.Clear();
                            string girdi;
                            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                            girdi = Console.ReadLine();
                            if(islem.NumarayiSil(girdi))
                                Console.WriteLine("İslem tamamlandı.");
                            else
                                Console.WriteLine("Bir problem oluştu");
                            Console.WriteLine("Yeni bir numara silmek istiyor musunuz ?(e/h)");
                            _secim = Console.ReadLine();
                        } while (_secim=="e"|| _secim=="e");
                        AnaMenu();
                    }
                    break;
                case 3:
                    {
                        string _secim;
                        do
                        {
                            Console.Clear();
                            string girdi, numara;
                            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                            girdi = Console.ReadLine();
                            if (islem.NumaraVarMı(girdi))
                            {
                                Console.WriteLine("Yeni Numarayı Giriniz:");
                                numara = Console.ReadLine();
                                if (islem.NumarayiGuncelle(girdi, numara))
                                    Console.WriteLine("İşlem Tamamlandı");
                                else
                                    Console.WriteLine("Bir sorun oluştu.");
                            }
                            else
                            Console.WriteLine("Bu isime ait bir kayıt bulunamadı.");
                            Console.WriteLine("Yeni bir numara güncellemek istiyor musunuz ?(e/h)");
                            _secim = Console.ReadLine();
                        } while (_secim =="e" || _secim == "E");
                        AnaMenu();

                    }
                    break;
                case 4:
                    {
                        islem.NumaralarıGoster();
                        Console.WriteLine("Herhangi bir tuşa basınız.");
                        Console.ReadKey();
                    }
                    AnaMenu();
                    break;
                case 5:
                    {
                        string _secim;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Arama yapmak istediğiniz tipi girin (isim, soyisim , numara)");
                            string girdi = Console.ReadLine();
                            if (islem.NumaraVarMı(girdi))
                            {
                                islem.RehberdeArama(girdi);
                                Console.WriteLine("İslem Tamamlandı.");
                            }
                            else
                                Console.WriteLine("Bir sorun oluştu.");
                            Console.WriteLine("Yeni bir numara aramak istiyor musunuz ? (e/h)");
                            _secim = Console.ReadLine();
                        } while (_secim == "e"|| _secim=="E");
                        AnaMenu();
                    }
                    break;

                default:
                    
                    break;
            }
        }
    }
}
