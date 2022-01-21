using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın
            
            int n = 0;
            Console.WriteLine("Lütfen bir Pozitif sayi girin: ");
            n = pozitifSayiCek();

            int[] Sayilar = new int[n];

            Console.WriteLine("Lütfen {0} adet Pozitif sayi girin: ",n);
            for (int i = 0; i < n; i++)
            {
                Sayilar[i] = pozitifSayiCek();
            }

            Console.WriteLine("Poizitif sayilar");
            foreach (var sayi in Sayilar)
            {
                if (sayi%2==0)
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
