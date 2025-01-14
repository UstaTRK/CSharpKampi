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

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //Dizide indexler 0'la başlar
            //string[] colors = new string[5];
            //colors[0] = "Sarı";
            //colors[1] = "Kırmızı";
            //colors[2] = "Mavi";
            //colors[3] = "Yeşil";
            //colors[4] = "Siyah";
            ////colors dizisindeki 3. elamanı yazdırma
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Ankara";
            //cities[1] = "Samsun";
            //cities[2] = "Ordu";
            //cities[3] = "Amasya";
            //cities[4] = "Yozgat";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Değer atanmayan dizi elemanını yazdırma
            //Console.WriteLine(numbers[5]);

            ////Dizi boyutu belirtmeden dizi tanımlama
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Mavi", "Yeşil", "Kırmızı", "Beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //Dizinin elemanlarından 3'e tam bölünenleri yazdırma

            //int[] numbers = { 4, 85, 426, 347, 789, 626, 56, 77 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3==0) 
            //    { 
            //    Console.WriteLine(numbers[i]);                
            //    }
            //}

            //char[] symbol = { 'X', '/', '!' };

            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //Dizideki en büyük sayıyı bulma

            //int[] myArray = { 47, 65, 26, 725, 643, 489, 985 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    { 
            //    maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "akın" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 45, 85, 77, 93, 68, 99, 123 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]+ " ");
            //}
            //Console.WriteLine();
            ////Dizinin elemanlarını sıralama
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]+" ");
            //}


            //int[] numbers = { 45, 85, 77, 93, 68, 99, 123 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();
            ////Dizinin elemanlarını terse döndürme
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            #endregion

            #region Dizi metodları
            //// Dizide belirtilen elemanın indexini bulma
            //string[] customers = { "ali", "ahmet", "yeliz", "deniz" };
            //int index = Array.IndexOf(customers, "yeliz");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 26, 63, 77, 52, 14, 20, 44 };

            //Console.WriteLine("Dizinin en büyük elemanı...: "+numbers.Max()+" Dizinin en küçük elemanı..:"+numbers.Min());

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz..:");
            //    cities[i]=Console.ReadLine();
            //}

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            ////Dizideki elemanları toplama
            //int[] numbers = { 45, 24, 66, 13, 78, 44 };
            //int sum=0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 99,100 };

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            #endregion

            #endregion

            Console.Read();
        }
    }
}
