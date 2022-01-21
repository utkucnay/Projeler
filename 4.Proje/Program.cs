using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Cümle yaz:");
            string cumle = Console.ReadLine();  

            char[] chars = cumle.ToCharArray();

            int space = 0;
            foreach (var item in chars)
            {
                if (item == ' ')
                {
                    space++;
                }
            }
            int cumleSayisi = space + 1;
            Console.Write("Cumle Sayisi: ");
            Console.WriteLine(cumleSayisi);

            Console.Write("Kelime Sayisi: ");
            Console.WriteLine(chars.Length-space);

            Console.ReadLine();
        }
    }
}
