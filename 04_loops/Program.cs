﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü 
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artık-azalış

            //int i;

            //for (i=1;i <=5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}


            //for (int i=1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}




            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishvalue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}







            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalvalue = 0;

            //for(int i=1; i<=10; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //            int totalvalue = 0;

            //            for (int i = 1; i<20; i++)
            //            {
            //if(i % 2 == 0)
            //                {
            //                    totalvalue += i;
            //                    Console.WriteLine(i);
            //                }
            //            }

            //            Console.WriteLine("--------");
            //            Console.WriteLine(totalvalue);



            //int count = 0;
            //for (int i = 1; i<=60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //1-2-4-8-16...

            //int bacterium = 1;
            //for(int i = 1; i<= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //İşlemler
            //}

            //int i = 1;

            //while (i <= 10) 
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i ++;
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

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            //Console.Write("Sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion




            Console.Read();
        }
    }
}
