using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("pozitif sayi girin:");
            int n = pozitifSayiCek();

            int[] Sayilar = new int[n];

            Console.WriteLine("Lütfen {0} adet Pozitif sayi girin: ", n);
            for (int i = 0; i < n; i++)
            {
                Sayilar[i] = pozitifSayiCek();
            }

            Console.WriteLine("sayilar dizisinin tersten");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(Sayilar[i]);
            }
            Console.ReadLine();
        }
        public static int pozitifSayiCek()
        {
            bool loop = true;
            int sayi = 0;
            while (loop)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 1)
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Lütfen pozitif sayi girin");
                }
            }
            return 0;
        }
    }
}
