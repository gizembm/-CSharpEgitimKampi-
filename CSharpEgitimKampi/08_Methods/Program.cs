using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriteMethod(string customerName) 
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Gizem Efe");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Gizem", "EFE");
            //CustomerCard("Şeyma", "EFE");

            #endregion

            #region Geriye Deger Döndürmeyen Int Parametreli Metodlar

            //void Sum(int x, int y, int z)
            //{
            //    Console.WriteLine(x + y + z);
            //}

            //Sum(1, 2, 3);
            //Sum(75, 41, 0);
            //Sum(852, 456, 741);

            #endregion

            #region Geriye DEğer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital +
            //                       " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Ülkenin Başkentini Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Ülkenin Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine((CountryCard(x, y, z)));

            //Console.WriteLine((CountryCard("ABD", "Washington", "Kırmızı/Beyaz/Lacivert")));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Avg(int num1, int num2, int num3)
            //{
            //    int result = (num1 + num2 + num3) / 3;

            //    return result;
            //}

            //Console.WriteLine(Avg(25, 75, 84));
            //Console.WriteLine(Avg(5, 5, 4));
            //Console.WriteLine(Avg(41, 41, 41));
            //Console.WriteLine(Avg(25, 75, 74));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2)
            //{
            //    int result = (exam1 + exam2) / 2;
            //    if (result > 50)
            //    {
            //        return student + " isimli öğrenci sınavı Geçti " + "Ortalama: " +
            //               result;
            //    }
            //    else
            //        return student + " isimli öğrenci sınavdan KALDI " + "Ortalama: " +
            //               result;

            //}

            //Console.WriteLine(ExamResult("Gizem", 100, 87));
            //Console.WriteLine(ExamResult("Erva", 45, 50));



            #endregion

            Console.Read();
        }
    }
}
