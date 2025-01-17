using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar
            // Geriye değer döndürmeyen medotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yılmaz");
            //    Console.WriteLine("Fatma Yılmaz");
            //    Console.WriteLine("Mehmet Öztürk");
            //    Console.WriteLine("Banu ÖZtürk");

            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}

            //Sum();

            #endregion

            #region Geriye değer döndürmeyen String parametreli metotlar

            //void WriteMethod (string customerName) 
            //{
            //    Console.WriteLine(customerName);

            //}

            //WriteMethod("Ali Yıldırım");

            //void CustomerCard(string name,string surName)
            //{ 
            //Console.WriteLine("Müşteri..:"+name+" "+surName);

            //}
            //CustomerCard("Ali", "Yılmaz");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion

            #region Geriye değer döndürmeyen Int parametreli metotlar
            //void Sum (int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(10, 20, 50);



            #endregion


            #region Geriye değer döndüren metotlar

            //string CustomerName() 
            //{
            //    return ("Buse Yıldız");
            //}

            //Console.WriteLine(CustomerName());


            #endregion

            #region Geriye değer döndüren String parametreli metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo=("Ülke..:"+countryName + "- Başkent..:" + capital + " - Bayrak Rengi..:"+flagColor);
            //    return(cardInfo);   
            //}
            //string x, y, z;
            //Console.Write("Ülkeyi Giriniz...:");
            //x=Console.ReadLine();
            //Console.Write("Başkenti Giriniz...:");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz...:");
            //z = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Geriye değer döndüren Int parametreli metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(55, 78));
            //Console.WriteLine(Sum(425, 321));
            //Console.WriteLine(Sum(69, 4647));
            //Console.WriteLine(Sum(1457, 2245));

            #endregion
            
            #region Örnek Uygulama
            //String ExamResult (String Student,int exam1,int exam2,int exam3) 
            //{
            //    int result = (exam1 + exam2 + exam3)/3;

            //    if (result >=50) 
            //    {
            //        return Student + "-- Öğrenci Sınavı Geçti" + " Ortalama..:" + result;
            //    }
            //    else {
            //        return Student+ "-- Öğrenci başarısız oldu"+" Ortalama...:"+result; 
            //    }

            //}
            //Console.WriteLine(ExamResult("Ali Yılmaz", 45, 55, 40));
            //Console.WriteLine(ExamResult("Akın Gül", 75, 60, 80));
            #endregion

            Console.Read();
        }
    }
}
