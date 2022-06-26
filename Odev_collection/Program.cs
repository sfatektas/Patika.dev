using System;
using System.Collections;

namespace Collections_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList nonasal = new ArrayList();
            int[] sayilar = new int[20];

            for (int i = 0; i < 20;)
            {
                try
                {
                    Console.WriteLine(i + 1 + ".sayıyı giriniz.");
                    int temp = Convert.ToInt32(Console.ReadLine());

                    if (temp > -1)
                    {
                        sayilar[i] = temp;
                        i++;
                    }
                    else
                        Console.WriteLine("Girilen sayı negatif olmamalıdır.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Girilen Input numeric olmalıdır.");
                }
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                bool isasal = true;
                for (int k = 2; k <= sayilar[i]/2 ; k++)
                {
                    if (sayilar[i] % k == 0 || sayilar[i]==1)
                    {
                        nonasal.Add(sayilar[i]);
                        isasal = false;
                        break;
                    }
                }
                if (isasal)
                    asal.Add(sayilar[i]);
            }
            foreach (var item in asal)
            {
                Console.WriteLine("Asal sayı: "+item);
            }
            foreach (var item in nonasal)
            {
                Console.WriteLine("Asal olmayan: "+item);
            }
        }
    }
}
