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

            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya!");
            // Console.Write("Nasılsın?");

            //Console.WriteLine("***** Yemek Tarifleri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-Soğuk Başlangıçlar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Tarifleri *****");
            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü, değişken_adı;

            //string name;
            //name = ("Murat");
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerMail, district, city;

            //customerName = "Ferhat";
            //customerSurname = "Bakış";
            //customerPhone = "+90 500 400 30 20";
            //customerMail = "deneme@gmail.com";
            //district = "Pendik";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerMail);
            //Console.WriteLine("Adres " + district + "/" + city);
            //Console.WriteLine("----------------------------");

            //Console.WriteLine();

            //customerName = "Aslı";
            //customerSurname = "Canan";
            //customerPhone = "+90 300 600 34 20";
            //customerMail = "test@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerMail);
            //Console.WriteLine("Adres " + district + "/" + city);
            //Console.WriteLine("----------------------------");



            #endregion

            #region İnt Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 420;
            int cokePrice = 110;
            int waterPrice = 25;
            int friesPrice = 85;
            int pizzaPrice = 380;
            int lemonadePrice = 75;


            Console.WriteLine("*** Restorant Fiyat Listesi ***");
            Console.WriteLine("Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("Patates: " + friesPrice + "TL");
            Console.WriteLine("Kola: " + cokePrice + "TL");
            Console.WriteLine("Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("Su: " + waterPrice + "TL");


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
            cokeCount = 5;
            waterCount = 6;
            friesCount = 7;
            pizzaCount = 8;
            lemonadeCount = 9;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------------");
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızarma tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Limonata tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam ödenecek tutar:" + totalPrice + "TL");



            #endregion 

            Console.Read();
        }
    }
}