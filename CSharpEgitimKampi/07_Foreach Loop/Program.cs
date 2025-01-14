using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:Değişken Türü
            //2:Değişken Adı
            //3:In (içinden)
            //4:Liste, Keleksiyon, Dizi

            //string[] cities = { "Ankara", "Roma", "Tokyo", "Paris" ,"Berlin","Londra"};
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers= { 36, 78, 96, 41, 3, 468, 646, 98, 321, 1546, 47865 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}   


            //Dizideki sayılardan 2'ye tam bölünenleri yazdırma
            //int[] numbers = { 36, 78, 96, 41, 3, 468, 646, 98, 321, 1546, 47865 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    { 
            //    Console.WriteLine(number);
            //    }
            //}

            //Dizideki sayıları toplama
            //int[] numbers = { 36, 78, 96, 41, 3, 468, 646, 98, 321, 1546, 47865 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;

            //}
            //Console.WriteLine(total);

            //List<"liste tipi"> "Liste Adı"= new List<"Değişken Tipi">();

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////Kelimeyi karakterlerine ayırma
            //string word = "Merhaba";

            //foreach (char c in word)
            //{ 
            //Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            
            ////Sınıftaki öğrenci sayısını öğrenme
            //Console.Write("Sınıfınızda Kaç Öğrenci Var?....:");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci iismlerini ve not ortalamalarını saklayacak dizilerin tanımlanması
            //string[] studentNames=new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin İsmini Giriniz...:");
            //    studentNames[i] = Console.ReadLine();
            //    Console.WriteLine("------------------------------");
            //    double totalExamResult= 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. notunu giriniz...:");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult+= value;
            //        Console.WriteLine("------------------------------");
            //    }
            //    studentExamAvg[i] = totalExamResult/3;
                                                
            //}

            ////Öğrencilerin ortalamaları
            //for (int i = 0; i < studentCount; i++) 
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin not ortalaması..: {studentExamAvg[i]}");
            //    Console.WriteLine("------------------------------");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("------------------------------");
            //}


            #endregion

            Console.Read();

        }
    }
}
