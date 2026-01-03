using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü 
            //Foreach(1;2;3;4)

            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] renkler = { "Sarı", "Kırmızı", "Mavi", "Yeşil", "Siyah" };
            //foreach (string renk in renkler)
            //{
            //    Console.WriteLine(renk);
            //}

            //int [] sayilar = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //int[] sayilar = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //foreach (int sayilar in sayilar)
            //{
            //    if(number%2==0)
            //    {
            //        Console.WriteLine(sayilar);
            //    }
            //}

            //int[] sayilar = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //int toplam = 0;
            //foreach (int i in sayilar)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //List<string> sehirler = new List<string>()
            //    {
            //    "İstanbul",
            //    "Ankara",
            //    "İzmir",
            //    "Bursa",
            //    "Antalya"
            //};

            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            //string word = "Merhaba Dünya";
            //foreach (char karakter in word)
            //{
            //    Console.WriteLine(karakter);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////Sınıfta öğrenci sayısının kullanıcıdan alınması
            //Console.WriteLine("--------------------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var?: ");
            //int ogrenciSayisi = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------------");

            ////Öğrenci isimlerinin ve not ortalamalarının saklamasını sağlayacak diziler
            //string[] ogrenciIsimleri = new string[ogrenciSayisi];
            //double[] ogrenciNotOrtalamalari = new double[ogrenciSayisi];

            ////Öğrenci isimlerinin ve not ortalamalarının kullanıcıdan alınması
            //for (int i = 0; i < ogrenciSayisi; i++)
            //{
            //  Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
            //    ogrenciIsimleri[i] = Console.ReadLine();               
            //    double notToplam = 0;

            //    //Her öğrenci için 3 notun girişi
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{ogrenciIsimleri[i]} isimli öğrencinin {j}. notunu giriniz: ");
            //        double not = double.Parse(Console.ReadLine());
            //        notToplam += not; // Notların toplanması
            //    }
            //    Console.WriteLine();
            //    ogrenciNotOrtalamalari[i] = notToplam / 3; // Not ortalamasının hesaplanması
                
            //}
            //    //Sınav ortalamaları
            //    for (int k = 0; k < ogrenciSayisi; k++)
            //    {
            //    Console.WriteLine("--------------------------------------------");

            //    Console.WriteLine($"{ogrenciIsimleri[k]} isimli öğrencinin not ortalaması: {ogrenciNotOrtalamalari[k]}");
            //     // Öğrencilerin geçip kalma durumu
            //        if (ogrenciNotOrtalamalari[k] >= 50)
            //        {
            //            Console.WriteLine("Durum: Geçti");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Durum: Kaldı");
            //        }

            //        Console.WriteLine("--------------------------------------------");  
              
            //}
          
                #endregion

                Console.ReadLine();


        }
    }
}
