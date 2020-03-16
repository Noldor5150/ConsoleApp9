using System;

namespace ConsoleApp9
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Iveskite pirma skaiciu");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            int NumberThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindBiggestNumber(NumberOne, NumberTwo, NumberThree));
        }
        static int  FindBiggestNumber(int a, int b,int c)
        {
            if (a>b && a>c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
