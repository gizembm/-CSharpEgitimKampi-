using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3 basamaklı bir sayının rakamlar toplamı

            Console.Write("3 basamaklı bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 99 || sayi < 1000)
            {
                int a = sayi / 100; //yüzler basamağı
                int b = sayi % 100 / 10; //onlar basamaği
                int c = sayi % 10; // birler basamaği
                int result = a + b + c;

                Console.WriteLine("Girdiğiniz sayının yüzler basamağı: " + a + "  onlarr basamağı: " + b +
                                   "  birler basamağı: " + c);
                Console.WriteLine("Rakamlar toplamı: " + result);


            }
            else
                Console.WriteLine("Lütfen 3 basamaklı bir sayı girdiğinize emin olunuz!!");

            Console.ReadLine();
            #endregion
        }
    }
}
