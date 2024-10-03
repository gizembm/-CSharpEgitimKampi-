using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkeni
            //double applePrice, strawberryPrice, orangePrice, tomatoPrice, potatoPrice;

            //applePrice = 14.85;
            //strawberryPrice = 45;
            //orangePrice = 20.95;
            //tomatoPrice = 6.88;
            //potatoPrice = 9.74;

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();
            //Console.WriteLine("----Elma birim fiyatı:" + applePrice + " TL");
            //Console.WriteLine("----Çilek birim fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("----Portakal birim fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("----Domates birim fiyatı:" + tomatoPrice + " TL");
            //Console.WriteLine("----Patates birim fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, strawberryGram, orangeGram, tomatoGram, potatoGram;

            //appleGram = 1.254;
            //strawberryGram = 0.750;
            //orangeGram = 2.477;
            //tomatoGram = 3.5;
            //potatoGram = 5.75;

            //double totalApplePrice, totalStrawberryPrice, totalOrangePrice, totalTomatoPrice, totalPotatoPrice, totalPrice;

            //totalApplePrice = appleGram * applePrice;
            //totalStrawberryPrice = strawberryGram * strawberryPrice;
            //totalOrangePrice = orangeGram * orangePrice;
            //totalTomatoPrice = tomatoGram * tomatoPrice;
            //totalPotatoPrice = potatoGram * potatoPrice;

            //totalPrice = totalApplePrice + totalStrawberryPrice + totalOrangePrice + totalTomatoPrice + totalPotatoPrice;

            //Console.WriteLine("****** Hesap ******");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat : " + applePrice + " TL" + " - Gramaj : " + appleGram + " kg" +
            //                   " - Toplam Tutar : " + totalApplePrice + " TL" );
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat : " + strawberryPrice + " TL" + " - Gramaj : " + 
            //                   strawberryGram + " kg" + " - Toplam Tutar : " + totalStrawberryPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat : " + orangePrice + " TL" + " - Gramaj : " + 
            //                   orangeGram + " kg" + " - Toplam Tutar : " + totalOrangePrice + " TL");
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat : " + tomatoPrice + " TL" + " - Gramaj : " + 
            //                    tomatoGram + " kg" + " - Toplam Tutar : " + totalTomatoPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat : " + potatoPrice + " TL" + " - Gramaj : " + 
            //                    potatoGram + " kg" + " - Toplam Tutar : " + totalPotatoPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Toplam Tutar : " + totalPrice + " TL");



            #endregion

            #region klavyeden string giriş alma
            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentyNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Numarası : ");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentyNumber + " - Yolcu Ad-Soyad: " + passengerName + " " +
            //                   passengerSurname + " - Yolcu ilçe/şehir bilgisi: " + passengerDistrict + "/" + passengerCity + 
            //                   " - Yolcu Yaş Bilgisi: " + passengerAge);
            #endregion

            #region klavyeden int giriş alma ve dönüştürme
            //int shoesPrice, computerPrice, chairPirce, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPirce = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen alınan ayakkabı adedini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen alınan bilgisayar adedini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen alınan sandalye adedini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen alınan televizyon adedini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairPirce * chairCount + tvPrice * tvCount;

            //Console.WriteLine("Toplam Tutar: " + totalPrice);
            #endregion

            #region klavyeden ondalık işlemleri
            //double exam1 , exam2 , exam3 , result;

            //Console.Write("1.sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.WriteLine();

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.Write("Sınav ortalamanız: " + result);



            #endregion

            #region klavyeden char girişi alma
            //char gender;
            //Console.Write("Lütfen cinsiyetinizi giriniz (K/E): ");
            //gender = char.Parse(Console.ReadLine());

            //if ((gender == 'k' || gender == 'K') || (gender == 'E' || gender == 'e'))
            //{
            //    Console.WriteLine("Girilen cinsiyet: " + gender);
                
            //}
            //else
            //    Console.WriteLine("Lütfen geçerli bir cinsiyet giriniz");
            


            #endregion



            Console.Read();
        }
    }
}
