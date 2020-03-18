using System;

namespace ConsoleApp9
{
    class Program
    {

        static void Main(string[] args)
        {
            int[]data = ArrayReferenceTest(5);
            PrintArrayValues(data);
            SpoilArray(data);
            PrintArrayValues(data);
        }
    

     
        static int [] ArrayReferenceTest(int a)
        {
            int[] numbers = new int [a];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("iveskite skaiciu");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            return numbers;

        }

        static void PrintArrayValues(int [] array)
        {
            foreach(int number in array)
            {
                Console.WriteLine(number);
            }
        }
        static int[] SpoilArray(int[] array) 
        {
            for(int i = 0; i<array.Length; i++)
            {
                array[i]= 0;
            }

            return array;
        }
    }
}
