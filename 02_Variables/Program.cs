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

            //number= 12.5;

            //Console.WriteLine(number);


            //Console.WriteLine("***** Manav Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice = 15.50;
            //double strawberryPrice = 12.30;
            //double bananaPrice = 20.10;
            //double orangePrice = 18.20;
            //double watermelonPrice = 22.50;


            //Console.WriteLine("Elma: " + applePrice + " TL");
            //Console.WriteLine("Çilek: " + strawberryPrice + " TL");
            //Console.WriteLine("Muz: " + bananaPrice + " TL");
            //Console.WriteLine("Portakal: " + orangePrice + " TL");
            //Console.WriteLine("Karpuz: " + watermelonPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine("*******************************");
            //Console.WriteLine("*******************************");
            //Console.WriteLine();

            //double appleGram, bananaGram, strawberryGram, orangeGram, watermelonGram;

            //appleGram = 500;
            //bananaGram = 450;
            //strawberryGram = 400;
            //orangeGram = 600;
            //watermelonGram = 750;

            //double appleTotalPrice = appleGram * applePrice;
            //double bananaTotalPrice = bananaGram * bananaPrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double watermelonTotalPrice = watermelonGram * watermelonPrice;


            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + 
            //    appleGram +"- Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Muz - " + "Birim Fiyat: " + bananaPrice + " - Gramaj: " +
            //    bananaGram + "- Toplam Tutar: " + bananaTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " +
            //    strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " +
            //    orangeGram + "- Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Karpuz - " + "Birim Fiyat: " + watermelonPrice + " - Gramaj: " +
            //    watermelonGram + "- Toplam Tutar: " + watermelonTotalPrice);

            //double shoppingTotalPrice= appleTotalPrice + bananaTotalPrice + strawberryTotalPrice +
            //    orangeTotalPrice + watermelonTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            // ABCDEFGHIJKLMNOPQRSTUVWXYZ

            // DEF..

            //TOPLANTI SAAT 20.00'DE
            // " '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerId, passengerDistrict, passengerAge,
            //passengerCity;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("TC Kimlik No: ");
            //passengerId = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerId + "Yolcu Adı Soyadı: "
            //+ passengerName + " " + passengerSurname + " " + passengerDistrict + " / " +
            //passengerCity + " " + passengerAge);












            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler 

            //ABC12D

            //int phonePrice, computerPrice, tvPrice, watchPrice, tabletPrice;

            //phonePrice = 21000;
            //computerPrice = 50000;
            //tvPrice = 80000;
            //watchPrice = 15000;
            //tabletPrice = 18000;

            //int phoneCount, computerCount, tvCount, watchCount, tabletCount;

            //Console.WriteLine("Lütfen aldığınız telefon sayısını giriniz: ");
            //phoneCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız saat sayısını giriniz: ");
            //watchCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız tablet sayısını giriniz: ");
            //tabletCount = int.Parse(Console.ReadLine());


            //int totalPrice = phoneCount * phonePrice + computerCount * computerPrice + tvCount * tvPrice +
            //watchCount * watchPrice + tabletCount * tabletPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen cinsiyetinizin baş harfini giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);

            #endregion

            Console.Read();
        }
    }
}
