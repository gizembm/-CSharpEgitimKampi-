using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "List" ve "foreach" kullanımı

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region string ifadeyi harfler ayırma

            //string word = "Gizem";

            //foreach (char harf in word)
            //{
            //    Console.WriteLine(harf);
            //}
            #endregion

            #region Örnek Sınav Sistemi

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            
            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;


                //her öğrenci için 3 sınav notu

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} adlı öğrencinin " +
                                  $"{j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Öğrencilerin sınav ortalaması 

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: " +
                                  $"{studentExamAvg[i]}");

                //Öğrencilerin kalıp geçme durumları
                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi GEÇTİ.");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten KALDI.");
                }

                Console.WriteLine("------------------------------") ;
            }

            #endregion

            Console.Read();






        }
    }
}
