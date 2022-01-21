using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("pozitif iki sayi girin:");
            int n = pozitifSayiCek();
            int m = pozitifSayiCek();

            int[] Sayilar = new int[n];

            Console.WriteLine("Lütfen {0} adet Pozitif sayi girin: ", n);
            for (int i = 0; i < n; i++)
            {
                Sayilar[i] = pozitifSayiCek();
            }

            Console.WriteLine("{0} bölünebilen sayilar",m);
            foreach (var sayi in Sayilar)
            {
                if (sayi % m == 0)
                {
                    Console.WriteLine(sayi);
                }
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
