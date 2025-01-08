using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Belirtilen yazıyı ekrana 5 kere yazdırma
            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");

            //}

            //1'den 20'ye kadar olan sayıları yazdırma
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //3'den 50'ye kadar 3'er 3'er saydırma
            //for (int i = 3;i<=50;i+=3) 
            //{ 
            //Console.WriteLine(i);
            //}

            //Kullanıcının istediği kadar Merhaba ifadesini yazdırma
            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Girin..: ");
            //int finisvalue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisvalue; i++)
            //{
            //    Console.WriteLine("Merhaba");
            //}
            #endregion

            #region For Döngüsüyle Karar Yapıları

            // 5'e tam bölünen sayıları yazdırma
            //for (int i = 0; i <= 100; i++)
            //{

            //if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1'den 10'a kadar olan sayıların toplamını bulma
            //int totalValue = 0;
            ////Değişkene başlangıç değeri vermeyi unutma !

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //1'den 20'ye kadar 2'ye tam bölünen sayıları ve toplamlarını bulma
            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue+=i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(totalValue);

            //1'den 50'ye kadar 7'ye tam bölünen kaç sayı olduğunu bulma
            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count ++;

            //    }
            //}
            //Console.WriteLine(count);

            //Saatte 2 ye katlanan, başlangıçta 1 adet olan bakterinin 24 saate kaç tane olacağını hesaplama

            //int bacterium = 1;

            //for (int i = 1;i<=24;i++)
            //{
            //    bacterium*=2;
            //    Console.WriteLine(i + " . saatin sonunda toplm bakteri sayısı...: "+bacterium);
            //}


            #endregion

            #region While Döngüsü
            //While döngüsünde önce şarta bakılır sonra işlem yapılır
            //While döngüsü ile ekrana 10 defa yazı yazdırma
            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba While Döngüsü");
            //    i++;
            //}

            //1'den 10'a kadar 3'e tam bölünen sayıları yazdırma 
            //int i = 1;

            //while(i<=10) 
            //{ 
            //if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //i++;
            //}

            //1'den 10'a kadar olan sayıları toplama

            //int i = 1;
            //int sum = 0;
            //while(i<=10) 
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamaklarının toplamını bulma

            
            //Console.Write("Sayıyı Girin....:");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds, sum;

            //ones = (number % 10);
            //tens = (number % 100)/10;
            //hundreds = number / 100;

            //sum=ones+tens+hundreds;
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
