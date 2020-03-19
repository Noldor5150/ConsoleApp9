using System;

using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5};
            PrintListValues(numbers);
            addToList(numbers);
            PrintListValues(numbers);
            
            Console.WriteLine(numbers.Count);
            Console.WriteLine(listIncludesNumber(numbers, 10));
        }
     
        static void PrintListValues(List<int>a)
        {
            foreach(int number in a)
            {
                Console.WriteLine(number);
            }
        }

        static List<int> addToList(List<int> list)
        {
            // tau cia returnas nera butinas. jo nenaudoji. (void uztektu)
              list.Add(7);
              return list;
        }

        static bool listIncludesNumber(List<int> list, int number)
        {
            return list.Contains(number);
        }
      
    }
}
