using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırmaKomutları
            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek kategorileri ****");
            #endregion

            #region string değişkeni
            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district, city;

            //customerName = "Gizem";
            //customerSurname = "EFE";
            //customerEmail = "efegizem562@gmail.com";
            //customerPhone = "+091234561212";
            //district = "Körfez";
            //city = "Kocaeli";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email Adresi :" + customerEmail);
            //Console.WriteLine("Adres :" + district + " / " + city);
            //Console.WriteLine("---------------------------------");

            #endregion

            #region int değişkeni
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadaPrice = 30;

            Console.WriteLine("****** Restoran Menüsü ******");
            Console.WriteLine();
            Console.WriteLine("----Hamburger : " + hamburgerPrice + " TL");
            Console.WriteLine("----Coke : " + cokePrice + " TL");
            Console.WriteLine("----Water : " + waterPrice + " TL");
            Console.WriteLine("----Fries : " + friesPrice + " TL");
            Console.WriteLine("----Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("----Lemonada : " + lemonadaPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("****** Restoran Menüsü ******");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 1;
            int waterCount = 2;
            int friesCount = 3;
            int pizzaCount = 4;
            int lemonadaCount = 5;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalFriesPrice = friesPrice * friesCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadaPrice = lemonadaPrice * lemonadaCount;

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice+ totalFriesPrice + totalPizzaPrice+ totalLemonadaPrice;

            Console.WriteLine("***** Hesap *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger : " + totalHamburgerPrice + " TL");
            Console.WriteLine("Coke : " + totalCokePrice + " TL");
            Console.WriteLine("Water : " + totalWaterPrice + " TL");
            Console.WriteLine("Fries : " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza : " + totalPizzaPrice + " TL");
            Console.WriteLine("Lemonada : " + totalLemonadaPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Hesap : " + totalPrice + " TL");
            Console.WriteLine() ;

            #endregion

            Console.Read();
        }
    }
}
