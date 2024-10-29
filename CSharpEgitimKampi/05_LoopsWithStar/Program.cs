using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region alt alta 10 tane yıldız oluşturma

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yıldızlar ile dik üçgen oluşturma


            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters dik üçgen

            //for (int i = 10; i >= 1 ; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region dik üçgen ve ters üçgen 

            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int k = 9;k >= 1; k--)
            {
                for (int m = 1;m <= k; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.ReadLine();
        }
    }
}
