using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{

            //    Console.WriteLine("şifre doğru");

            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğru");
            //}
            //else
            //{
            //    Console.Write("hatali bilgi");
            //}

            //int number;
            //Console.Write("Sayi gir:");
            //number= int.Parse(Console.ReadLine());    

            //if(number == 5)
            //{
            //    Console.WriteLine("sayi dogru");
            //}
            //else
            //{
            //    Console.WriteLine("sayi hatali");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("sinav 1;");
            //exam1=int.Parse(Console.ReadLine());   
            //Console.Write("sinav 2;");
            //exam2=int.Parse(Console.ReadLine());   
            //Console.Write("sinav 3;");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sinavlarin ortalamasi:" + average); 

            //if(average > 0 & average < 50)
            //{ 
            //    result = " Sonuc vasat";
            //}
            //if(average > 50 & average <=70)
            //{
            //    result = " sonuc orta";
            //}
            //if(average > 70 & average <=84)
            //{
            //    result = " sonuc iyi";
            //}
            //if (average > 84)
            //{
            //    result = " sonuc harika";
            //}
            //else
            //{
            //    result = " HATALI GİRİŞ";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("lutfen sehir girisi yapiniz: ");
            //city = Console.ReadLine();

            //if(city == "adana=" | city == " ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.Write("lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.Write("bu kullanici adi kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hosgeldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);  

            //Console.Write("1. sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. sayinin 2. sayiya bolumunden kalan: " + result);


            //Console.Write("LUTFEN SAYIYI GIRINIZ: ");
            //int number=int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("sayi ciftir");
            //}
            //else
            //{
            //    Console.WriteLine("sayi tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("lutfen takim sembolunu giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team =='f' | team == 'F')
            //{
            //    Console.Write("Fenerbahce");
            //} 
            //if(team =='b' | team == 'B')
            //{
            //    Console.Write("Besiktas");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("-=-=-=-=- EGITIM KAMPI RESTORANTI -=-=-=-=- ");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü numarasını girin:");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Ana yemekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kömürde Izgara Köfte");
            //    Console.WriteLine("2- Kuru fasülye - Pilav");
            //    Console.WriteLine("3- Izgara Balık");
            //    Console.WriteLine("4- Tavuk Makarna");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Ana yemekler --------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Çorbalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kelle Paça");
            //    Console.WriteLine("2- Mercimek Çorbası");
            //    Console.WriteLine("3- Ezogelin");
            //    Console.WriteLine("4- Kremalı Tavuksuyu Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Çorbalar --------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Pizzalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Napoliten Pizza");
            //    Console.WriteLine("2- Karışık Pizza");
            //    Console.WriteLine("3- 4 Peynirli Pizza");
            //    Console.WriteLine("4- Sucuk Kaşarlı Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Pizzalar --------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- İçecekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Fanta ");
            //    Console.WriteLine("3- Ayran");
            //    Console.WriteLine("4- Su");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- İçecekler --------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Tatlılar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- San Sebastian");
            //    Console.WriteLine("2- Puding  ");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("4- Spangle");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Tatlılar --------------");
            //}



            #endregion

            #region Switch Case

            //Console.Write("Lutfen ay giriniz: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;

            //}

            #endregion

            #region Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayiyi Giriniz: ");
            //number1=int.Parse(Console.ReadLine());
            
            //Console.Write("2. Sayiyi Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen yapmak istediginiz islemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
                
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpı: " + result);
            //        break;
               
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}

            #endregion
            
            Console.Read();
        }
    }
}
