using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bir dizide max sayıyı bulma
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region dizi metotları

            //küçükten büyüğe
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //diziyi tersten yazdırma
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //istenilen indexi bulma
            //string[] customers = { "ali", " Buse", "aysegül", "merve", "çinar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //max - min 
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + 
            //                  " Dizinin en küçük elemanı: " + numbers.Min());





            #endregion

            #region kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //}

            //Console.WriteLine(sum);

            #endregion

            #region bir dizideki elemanları çift ve tek durumlarına göre "list" yapısına ekleme
            //int[] numbers = { 45, 74, 87, 98, 85, 71, 23, 12, 45, 14, 562 };

            //List<int> tek = new List<int>();
            //List<int> cift = new List<int>();


            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        cift.Add(numbers[i]);
            //    }
            //    else
            //    {
            //        tek.Add(numbers[i]);
            //    }
            //}

            //Console.WriteLine("Tek sayılar: " + String.Join(", ", tek));
            //Console.WriteLine("Çift sayılar: " + String.Join(", ", cift));

            
            #endregion



            Console.Read();
        }
    }
}
