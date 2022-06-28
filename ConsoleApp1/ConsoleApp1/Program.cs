using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    MailPasword("cavid@code.edu.az", 12345);
            //}
            //static void MailPasword(string gmail, int password)
            //{
            //    if (gmail == "cavid@code.edu.az" && password == 12345)
            //    {
            //        Console.WriteLine("Girish olundu");
            //    }
            //    else
            //    {
            //        Console.WriteLine("mail ve ya password sehvdir");
            //    }
            Factorial(3);
        }



        static void Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
                
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
