﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Girin...:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Girin:");
            //capital= Console.ReadLine();

            //Console.Write("Ülkeyi Girin:");
            //country= Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result=" Hata!!!";

            //Console.Write("Sınav 1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.Write("Sınavların Ortalaması..: " + average);
            //if (average>0 & average<=50)
            //{
            //    result = "Sonuç Kötü";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84 & average <= 100)
            //{
            //    result = "  Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Şehiri Girin:");
            //city = Console.ReadLine();

            //if (city=="ordu" | city=="samsun" | city == "trabzon" | city == "izmir") 
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir Mevcut değil");
            //}

            //Console.Write("Lütfen Kulanıcı Adınızı Girin...:");
            //string username=Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Hatalı!");
            //}
            //else 
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 37;
            //int result =number % 5;

            //Console.WriteLine(result);

            //Console.Write("Lütfen Birinci Sayıyı Girin..:");
            //int number1=int .Parse(Console.ReadLine());
            //Console.Write("Lütfen İkinci Sayıyı Girin..:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("Birinci Sayının İkinci Sayıya Bölümünden Kalan ...: "result);

            //Console.Write("Lütfen Sayıyı Girin...:");
            //int number=int .Parse(Console.ReadLine());

            //if (number%2==0) 
            //{
            //    Console.WriteLine("Sayı Çift");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Tek");
            //}
            #endregion
            #region Char Değişkenleri İle Karar Yapıları
            //Console.Write("Lütfen Takım Sembolünü Giriniz...:");
            //char team;
            //team=char.Parse(Console.ReadLine());

            //if (team=='g'|team=='G') 
            //{
            //    Console.WriteLine("Galatasaray");

            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");

            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");

            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");

            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*****C# Eğitim Kampı Restorant*****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detay görmek istediğiniz menüyü seçin..:");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine("***** Ana Yemekler *****");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine("1 - Köri Soslu Tavuk");
            //    Console.WriteLine("2 - Biftek");
            //    Console.WriteLine("3 - İskender");
            //    Console.WriteLine("4 - Adana");
            //    Console.WriteLine("5 - Ciğer");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("***** Çorbalar *****");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine("1 - Mercimek");
            //    Console.WriteLine("2 - Haşlama");
            //    Console.WriteLine("3 - Ezo Gelin");
            //    Console.WriteLine("4 - Yayla");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("***** Pizzalar *****");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine("1 - Peynirli");
            //    Console.WriteLine("2 - Vejeteryan");
            //    Console.WriteLine("3 - Peperoni");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("***** İçecekler *****");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("3 - Limonata");
            //    Console.WriteLine("4 - Su");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("***** Tatlılar *****");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine("1 - Baklava");
            //    Console.WriteLine("2 - Künefe");
            //    Console.WriteLine("3 - Sütlaç");
            //    Console.WriteLine("4 - Kazandibi");
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //int montNumber;
            //Console.Write("Lütfen Ay Girişi Yapın...:");
            //montNumber=int.Parse(Console.ReadLine());

            //switch (montNumber) 
            //{
            //    case 1:Console.WriteLine("Ocak");break;
            //    case 2:Console.WriteLine("Şubat");break;
            //    case 3:Console.WriteLine("Mart");break;
            //    case 4:Console.WriteLine("Nisan");break;
            //    case 5:Console.WriteLine("Mayıs");break;
            //    case 6:Console.WriteLine("Haziran");break;
            //    case 7:Console.WriteLine("Temmuz");break;
            //    case 8:Console.WriteLine("Ağustos");break;
            //    case 9:Console.WriteLine("Eylül");break;
            //    case 10:Console.WriteLine("Ekim");break;
            //    case 11:Console.WriteLine("Kasım");break;
            //    case 12:Console.WriteLine("Aralık");break;
            //    default:Console.WriteLine("Hatalı Giriş");break;

            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2,result;
            //char process;
            //Console.Write("İlk Sayıyı Girin :");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Girin :");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("İşlemi Seçin :");
            //process = char.Parse(Console.ReadLine());

            //switch (process) 
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama İşlemi Sonucu..:" + result);break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma İşlemi Sonucu..:" + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma İşlemi Sonucu..:" + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme İşlemi Sonucu..:" + result); break;
            //    default:Console.WriteLine("Hatalı Giriş!");break;
            //}



            #endregion

            Console.Read();
        }
    }
}
