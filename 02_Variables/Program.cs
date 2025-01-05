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
            #region Double Değişkenler


            //double number;

            //number = 3.25;
            //Console.WriteLine(number);

            //Console.WriteLine("========= Fiyat Listesi =========");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 16.99;
            //orangePrice = 21.49;
            //strawberryPrice = 18.99;
            //potatoPrice = 6.49;
            //tomatoPrice = 4.99;

            //Console.WriteLine("---- Elma Kg Fiyati     : " + applePrice + " TL");
            //Console.WriteLine("---- Portalak Kg Fiyati : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Kg Fiyati    : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Kg Fiyati  : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Kg Fiyati  : " + tomatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.310;
            //strawberryGram = 2.380;
            //potatoGram = 4.870;
            //tomatoGram = 2.750;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //double basketTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //double kdvPercentage;
            //kdvPercentage = 18;


            //Console.WriteLine("=========== Sepet ===========");
            //Console.WriteLine();

            //Console.WriteLine("Alinan Urun: Elma; ");
            //Console.WriteLine("Birim Fiyati: " + applePrice + " TL");
            //Console.WriteLine("Gramaj: " + appleGram + " KG/GR");
            //Console.WriteLine("Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Alinan Urun: Portakal; ");
            //Console.WriteLine("Birim Fiyati: " + orangePrice + " TL");
            //Console.WriteLine("Gramaj: " + orangeGram + " KG/GR");
            //Console.WriteLine("Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Alinan Urun: Çilek; ");
            //Console.WriteLine("Birim Fiyati: " + strawberryPrice + " TL");
            //Console.WriteLine("Gramaj: " + strawberryGram + " KG/GR");
            //Console.WriteLine("Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Alinan Urun: Patates; ");
            //Console.WriteLine("Birim Fiyati: " + potatoPrice + " TL");
            //Console.WriteLine("Gramaj: " + potatoGram + " KG/GR");
            //Console.WriteLine("Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Alinan Urun: Domates; ");
            //Console.WriteLine("Birim Fiyati: " + tomatoPrice + " TL");
            //Console.WriteLine("Gramaj: " + tomatoGram + " KG/GR");
            //Console.WriteLine("Toplam Tutar: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("=========== Sepet ===========");
            //Console.WriteLine();
            //Console.WriteLine("Sepet Toplam Tutarı: " + basketTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Sepet KDV Dahil Toplam Tutarı: " + (basketTotalPrice + (basketTotalPrice * (kdvPercentage / 100))) + " TL");
            //Console.WriteLine();


            #endregion

            #region Char Değişkenler

            //char symbol;

            //symbol = 'a';   

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("----- CSharp Airlines Yolcu Bilgisi -----");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdNumber = Console.ReadLine(); 


            //Console.WriteLine();

            //Console.WriteLine("==========================");
            //Console.WriteLine("Yolcu TC No: "+ passengerIdNumber + " Yolcu: " + passengerName + " " + passengerSurname + " ," + passengerDistrict + "/" + passengerCity + "  " +passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 2000;
            //tvPrice = 15000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplan Ödemeniz Gereken Tutar: " + totalPrice);





            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav Ortalamanız; " + result);




            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz :";
            //gender = char.Parse(Console.ReadLine());

            #endregion

            Console.Read();

        }
    } 
}
