using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cumleyi_sayi_kadar_yazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Cümle Giriniz ");
            string cumle = Console.ReadLine();
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("{0}. {1}", (i + 1), cumle);
            }
            Console.ReadKey(); 
            //gayet güzel olmuş ayrıca github isimlendirmen doğru ve eksiksiz
        }
    }
}
