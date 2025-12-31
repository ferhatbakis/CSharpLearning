using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Authentication;
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
            //password= Console.ReadLine();
            //if (password == "ferhat123")

            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;

            //Console.Write("Ülkeyi giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Şehri giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "mardin" & country== "türkiye")
            //{ 
            //Console.WriteLine("Veriler doğrulandı!");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler doğrulanamadı.");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5) 
            //    {
            //    Console.WriteLine("Doğru sayı.");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sayı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1.Sınav Notunuz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notunuz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notunuz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average < 50) ;
            //Console.WriteLine("Sonuç vasat.");

            //if (average >= 50 & average < 69) ;
            //Console.WriteLine("Sonuç orta.");

            //if (average >= 70 & average < 85) ;
            //Console.WriteLine("Sonuç iyi.");

            //if (average >= 85) ;
            //Console.WriteLine("Sonuç çok iyi.");


            //Console.WriteLine("result");

            //string city;
            //Console.WriteLine("Lütfen şehrinizi giriniz.");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="istanbul" | city=="edirne" |city=="bursa")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin") 
            //{ 
            //    Console.Write("Bu kullanıcı adı kabul edilemez.");
            //}

            //else
            //{
            //    Console.Write("Bu kullanıcı adı uygundur.");
            //}










            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz.");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz.");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("Birinci sayının ikinci sayıya bölümü: " + result);

            //Console.Write("Lütfen sayıyı giriniz. ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.WriteLine("lütfen takımınızın sembolünü giriniz.");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}



            #endregion

            #region Örnek Proje Uygulaması
         
            //    Console.WriteLine("****** C# Eğitim Kampı Restoranı ******");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------------------------------");
            //    Console.WriteLine("1-Ana yemekler");
            //    Console.WriteLine("2-Çorbalar");
            //    Console.WriteLine("3-Yan yemekler");
            //    Console.WriteLine("4-İçecekler");
            //    Console.WriteLine("5-Tatlılar");
            //    Console.WriteLine("-----------------------------------------");
            //    Console.WriteLine();
            
            //    string menuItem;

            //    Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //    menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //Console.WriteLine("****** C# Eğitim Kampı Restoranı ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Yan yemekler");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();
            //}
     
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Domates çorbası");
            //    Console.WriteLine("3-Yoğurt çorbası");
            //    Console.WriteLine("4-Ezogelin çorbası");
            //    Console.WriteLine("--------------Çorbalar-------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Yan yemekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Çiğköfte");
            //    Console.WriteLine("2-Meze");
            //    Console.WriteLine("3-Közlenmiş biber");
            //    Console.WriteLine("4-Yoğurt");
            //    Console.WriteLine("--------------Yan yemekler-------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İçecekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-CocaCola");
            //    Console.WriteLine("2-Pepsi");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-FuseTea");
            //    Console.WriteLine("--------------İçecekler-------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Ekler");
            //    Console.WriteLine("4-Tulumba");
            //    Console.WriteLine("--------------Tatlılar-------------------");
            //    Console.WriteLine();
            //}





            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişini yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)

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

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. sayıyı giriniz.");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz.");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz.");
            //symbol = char.Parse(Console.ReadLine());

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
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

                    #endregion

             Console.Read();



            

        }
    }
}
