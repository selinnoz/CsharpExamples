using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 positive numbers!");        
           // Console.WriteLine("1-");
            int n= Convert.ToInt16(Console.ReadLine());               // n sayisi alinir
           // Console.WriteLine("2-");
            int m = Convert.ToInt16(Console.ReadLine());              // m sayisi alinir

            Console.WriteLine("Please enter "+ n + " positive numbers!");         // kullanicidan n adet sayi istenir

            int[] a = new int[n];
            for (int i = 0; i < n; i++)                          // n adet sayi bir dizide tutulur
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % m == 0)
                {
                    Console.WriteLine(a[i] + " divided by " + m + " equals 0. Complete division!"); //girilen sayilardan m' e tam bölünenler
                }
                else
                    Console.WriteLine(a[i] + " can't divided by " + m + "!");      //m'e bölünemeyen sayilar
                if (a[i]  == m )
                {
                    Console.WriteLine(a[i] + " is equal to " + m + "!");       //girilen sayilardan m e esit olanlar
                }
            }


            Console.Read();
        }
    }
}
