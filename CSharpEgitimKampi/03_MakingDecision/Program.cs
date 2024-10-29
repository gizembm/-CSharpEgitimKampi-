using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            double vize, final, odev = 0;
            string lesson, harfNotu;
            Console.WriteLine("Dersin adını giriniz:");
            lesson = Console.ReadLine();

            Console.WriteLine("Vize notunuzu giriniz:");
            vize = double.Parse(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz:");
            final = double.Parse(Console.ReadLine());
            
            //odev verilen dersler
            if (lesson == "VTYS" || lesson == "İşletim sistemi")
            {
                Console.WriteLine("Ödev notununuzu giriniz:");
                odev = double.Parse(Console.ReadLine());

                double mark = CalculateMark(vize, final, odev, lesson);
                harfNotu = HarfNotuHesapla(mark);

                Console.WriteLine($"Harf Notunuz: {harfNotu}");

            }

            //odevsiz dersler
            else if(lesson == "BA1" ||  lesson == "BDSM" || lesson == "İşaret ve Sistemler")
            {
                double mark = CalculateMark(vize, final, odev ,lesson);
                harfNotu = HarfNotuHesapla(mark);

                Console.WriteLine($"Harf Notunuz: {harfNotu}");
            }

            

            Console.ReadLine();
        }
        // Notu hesaplayan fonksiyon
        static double CalculateMark(double vize, double final, double odev, string lesson)
        {
            if (lesson == "VTYS" || lesson == "İşletim sistemi")
                return (vize * 0.35) + (final * 0.45) + (odev * 0.2);
            else
                return (vize * 0.4) + (final * 0.6);
        }

        // Harf notunu hesaplayan fonksiyon
        static string HarfNotuHesapla(double mark)
        {
            switch (mark)
            {
                case double n when n >= 90: return "AA";
                case double n when n >= 85: return "BA";
                case double n when n >= 80: return "BB";
                case double n when n >= 75: return "CB";
                case double n when n >= 65: return "CC";
                case double n when n >= 60: return "DC";
                case double n when n >= 55: return "DD";
                case double n when n >= 45: return "FD";
                case double n when n < 45: return "FF";
                default: return "Girdiğiniz notları kontrol ediniz !!!";
            }
        }
    }
}
