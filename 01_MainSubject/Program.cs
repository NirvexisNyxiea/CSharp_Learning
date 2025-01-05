using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdirmalar

            //Console.WriteLine("Hello World");

            //Console.Write("Selam");
            //Console.Read(); 

            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Mezeler");
            //Console.WriteLine("2-Icecekler");
            //Console.WriteLine("3-Corbalar");
            //Console.WriteLine("4-Ana Yemek");
            //Console.WriteLine("5-Tatli");
            //Console.WriteLine("5-Salatalar");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri ******");

            #endregion

            #region String Degiskenler
            //Degiskenler;
            //string
            // Degisken_turu  degisken_adi;

            //string name;
            //name = "Fafa";
            //Console.Write(name);  

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Muhammed";
            //customerSurname = "Jacob";
            //customerPhone = "+90 555 433 32 12";
            //customerEmail = "jacob_muhammed@gmail.com";
            //district = "Suriye";
            //city = "Damascus";

            //Console.WriteLine("*********** Kullanici Karti ***********");
            //Console.WriteLine();
            //Console.WriteLine("=======================================");
            //Console.WriteLine("Musteri Adi:" + " " + customerName + " " + customerSurname);
            //Console.WriteLine("GSM:" + " " + customerPhone);
            //Console.WriteLine("e-Posta:" + " " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("=======================================");


            #endregion

            #region Int Degiskenler

            // Tam Sayi degiskenler int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("===== Restorant Menu Fiyatlari ====");
            Console.WriteLine();
            Console.WriteLine("--- Hamburger : " + hamburgerPrice + " TL");
            Console.WriteLine("--- Pizza     : " + pizzaPrice + " TL");
            Console.WriteLine("--- Kola      : " + cokePrice + " TL");
            Console.WriteLine("--- Limonata  : " + lemonadePrice + " TL");
            Console.WriteLine("--- Kizartma  : " + friesPrice + " TL");
            Console.WriteLine("--- Su        : " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("===== ----- Afiyet Olsun ------ ====");
            Console.WriteLine();



            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            lemonadeCount = 0;
            pizzaCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;  
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;  
            totalLemonadePrice= lemonadeCount * lemonadePrice;

            

            Console.WriteLine("------------- HESAP ---------------");
            Console.WriteLine("Toplam Hamburger Tutari: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Toplam Kola Tutari: " + totalCokePrice + " TL");
            Console.WriteLine("Toplam Su Tutari: " + totalWaterPrice + " TL");
            Console.WriteLine("Toplam Patates Kizartmasi Tutari: " + totalFriesPrice + " TL");
            Console.WriteLine("Toplam Pizza Tutari: " + totalPizzaPrice + " TL");
            Console.WriteLine("Toplam Limonata Tutari: " + totalLemonadePrice + " TL");
            Console.WriteLine();
            
            int totalPrice= totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice +totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Hesap Tutari : " +totalPrice + " TL");

            Console.WriteLine();



            
            #endregion



            Console.Read();
        }
    }
}




// Yazdirma komutlari
//
