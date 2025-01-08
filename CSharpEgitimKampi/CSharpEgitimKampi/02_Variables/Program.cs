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

            //double applePrice, orangePrice, strawberyPrice, potatoPrice, tomatoPrice;

            //Console.WriteLine("******Fiyat Listesi*****");
            //Console.WriteLine();
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberyPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Kg Fiyatı...:" + "" + applePrice + " TL");
            //Console.WriteLine("Portakal Kg Fiyatı...:" + "" + orangePrice + " TL");
            //Console.WriteLine("Çilek Kg Fiyatı...:" + "" + strawberyPrice + " TL");
            //Console.WriteLine("Patates Kg Fiyatı...:" + "" + potatoPrice + " TL");
            //Console.WriteLine("Domates Kg Fiyatı...:" + "" + tomatoPrice + " TL");

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine(); 

            //double appleWeight, orangeWeight, strawberyWeight, potatoWeight, tomatoWeight;

            //appleWeight = 1.245;
            //orangeWeight = 2.650;
            //strawberyWeight = 0.750;
            //potatoWeight = 4.859;
            //tomatoWeight = 3.745;

            //double appleTotalPrice, orangeTotalPrice, strawberyTotalPrice, potatoTotalPrice, tomatoTotalPrice;
            //appleTotalPrice = appleWeight * applePrice;
            //orangeTotalPrice = orangeWeight * orangePrice;
            //strawberyTotalPrice = strawberyWeight * strawberyPrice;
            //potatoTotalPrice = potatoWeight * potatoPrice;
            //tomatoTotalPrice = tomatoWeight * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat:" + " " + applePrice + " - Ağırlık :" + " " + appleWeight + " Kg" + " Toplam Tutar :" + " " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat:" + " " + orangePrice + " - Ağırlık :" + " " + orangeWeight + " Kg" + " Toplam Tutar :" + " " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat:" + " " + strawberyPrice + " - Ağırlık :" + " " + strawberyWeight + " Kg" + " Toplam Tutar :" + " " + strawberyTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat:" + " " + potatoPrice + " - Ağırlık :" + " " + potatoWeight + " Kg" + " Toplam Tutar :" + " " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat:" + " " + tomatoPrice + " - Ağırlık :" + " " + tomatoWeight + " Kg" + " Toplam Tutar :" + " " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberyTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Alışveriş Toplam Tutarı....: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'X';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***CSharp Hava Yolları Yolcu Bilgileri***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu adı...:");
            //passengerName=Console.ReadLine();
            //Console.Write("Yolcu Soyadı...:");
            //passengerSurname =Console.ReadLine();
            //Console.Write("İlçe Bilgisi...:");
            //passengerDistrict =Console.ReadLine();
            //Console.Write("İl Bilgisi...:");
            //passengerCity =Console.ReadLine();
            //Console.Write("Yolcu Yaşı...:");
            //passengerAge =Console.ReadLine();
            //Console.Write("TC Kimlik No...:");
            //passengerIdentityNumber =Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine("Yolcu....: "+passengerName+" "+passengerSurname+" "+passengerDistrict+"/"+passengerCity+" "+passengerAge+" "+passengerIdentityNumber);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice,computerPrice,chairPrice,tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 1500;
            //tvPrice = 50000;

            //int shoesCount,computerCount,chairCount,tvCount;
            
            //Klavyeden veri girişinde gelen değer sistem tarafından String olarak kabul edilir.
            //Klavyeden okunan değeri String haricindeki tüm değişkenlere aktarırken Parse ifadesini kullanmalıyız.
            
            //Console.Write("Lütfen aldığınız ayakkabı sayısını girin..:");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını girin..:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını girin..:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını girin..:");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * tvPrice + tvCount * tvPrice;

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Toplam Tutar....: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Girin...:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Girin...:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Girin...:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız...: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Giriniz...:");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet...: "+gender);


            #endregion

            Console.Read();

        }


    }
}
