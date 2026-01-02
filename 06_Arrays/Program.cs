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
            #region Temel Dizi Örnekleri

            //2.4.6.8
            //sarı, kırmızı, mavi, yeşil, siyah
            //Ali, Veli, Ayşe, Fatma
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı];

            //string[] renkler = new string[5];
            //renkler[0] = "sarı";
            //renkler[1] = "kırmızı";
            //renkler[2] = "mavi";
            //renkler[3] = "yeşil";
            //renkler[4] = "siyah";
            //Console.WriteLine(renkler[2]);
            //Console.WriteLine(renkler[3]);

            //string[] şehirler = new string[6];
            //şehirler[0] = "İstanbul";
            //şehirler[1] = "Ankara";
            //şehirler[2] = "İzmir";
            //şehirler[3] = "Bursa";
            //şehirler[4] = "Antalya";
            //şehirler[5] = "Adana";
            //Console.WriteLine(şehirler[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 2;
            //numbers[1] = 16;
            //numbers[6] = 748;
            //Console.WriteLine(numbers[1]);

            //string cities="İstanbul,Ankara,İzmir,Bursa,Antalya,Adana";

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Yeşil", "Siyah" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //for (int i=0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol= { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray= { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            //int maxNumber = myArray[0]; 

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] fruits = { "Elma", "Armut", "Muz", "Çilek", "Karpuz", "Şeftali" };
            //Console.WriteLine(fruits.Length);

            //int[] numbers = { 10, 23, 45, 67, 89, 12, 34, 56, 78, 90 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 10, 23, 45, 67, 89, 12, 34, 56, 78, 90 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion

            #region Dizi Metotlar

            //string[] animals = { "Kedi", "Köpek", "Kuş", "Balık", "At" };
            //int index = Array.IndexOf(animals, "Kuş");
            //Console.WriteLine(index);

            //int[] numbers = { 10, 23, 45, 67, 89, 12, 34, 56, 78, 90 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "Dizinin en küçük elemanı :" + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for(int i=0;i<cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{ 
            //    Console.WriteLine(cities[i]); 
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for( int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);


            //int[] numbers = { 13, 53, 56, 864, 86, 897, 13, 76, 22, 41 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion


            Console.Read();

        }
    }
}
