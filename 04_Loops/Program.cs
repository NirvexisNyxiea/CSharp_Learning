﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü

            //x: baslangic degerini tutar 
            //y; bitis degerini tutar end value
            //x; artis ya da azalis degelerini tutar increase decrease ===================== onemli unutma==

            //int i;

            //for (i =1; i<=5; i++)
            //{
            //    Console.WriteLine("Csharp Egitim kampi");
            //}

            //for (int i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i<= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write(" Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int maxValue =int.Parse(Console.ReadLine());

            //for (int i = 1; i <= maxValue; i++)
            //{
            //    Console.WriteLine("CSharp eglenceli");
            //}


            //Console.Write("Başlangıç değerini giriniz: ");
            //int startNum = int.Parse(Console.ReadLine());
            //Console.Write("Durdurmak istediğiniz değeri giriniz: ");
            //int endNum = int.Parse(Console.ReadLine());
            //Console.Write("Kaçar birim artmasını istiyorsanız o değeri giriniz: ");
            //int incDecrease = int.Parse(Console.ReadLine());

            //for (int i = startNum; i <= endNum; i += incDecrease)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region For döngüsü ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}   

            //int totalValue = 0;

            //for (int i = 1; i <=10 ; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda: " + bacterium);
            //}

            #endregion

            #region while döngüsü

            //while(sart)
            //{ islemler }

            //int i = 1; 

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba donguler");
            //    i++;
            //}

            //int i = 1;

            //while(i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum); 

            #endregion

            #region ornek Sinav Sorusu

            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("sayi giriniz: ");
            //int number= int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(hundreds + "+" + tens + "+" + ones);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);


            #endregion



            Console.Read();
        }
    }
}
