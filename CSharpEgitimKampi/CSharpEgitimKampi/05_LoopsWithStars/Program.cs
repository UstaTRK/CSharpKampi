﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta on tane yıldız oluşturma

            //for (int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana on tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta on tane yıldız oluşturma, her satırda on tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}



            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {                
            //    Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik üçgen

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve ters dik üçgen

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 9; k >= 1; k--)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi
            //int n =10;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n*2-1; j > 0; j--)
            //    {

            //        Console.Write(" ");

            //    }



            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {

            //        Console.Write("*");

            //    }

            //    Console.WriteLine();

            //}

            //for (int i = n-1; i >0; i--)
            //{
            //    for (int j = n * 2 - 1; j > 0; j--)
            //    {

            //        Console.Write(" ");

            //    }

            //    for(int k = 1; k <= 2 * i - 1; k++) 
            //    {
            //    Console.Write("*");
            //    }

            //Console.WriteLine();

            //}

            #endregion

            #region Piramit

            //int n = 10;

            //for (int i = 1; i <= n; i++) 
            //{ 

            //    for (int j = n-i; j >0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Ters piramit

            //int n = 10;
            //for (int i=n;i>=1;i--)
            //{
            //    for(int j=n-i;j>0;j--) 
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion



            Console.Read();
        }
    }
}
