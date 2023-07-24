using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

//2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

//3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

//4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number:");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Now give me " + n + " number:");
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine( i+1 +" . number");
                numbers[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.Read();

        }
        
    }
}
