using System;

namespace ConsoleApp9
{
    class Program
    {

        static void Main(string[] args)
        {
            /*const double Pi = 3.14;
            int Radius = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine($"Apskritimo plotas yra {Pi * Radius * Radius}");
            Console.ReadKey();
            Console.WriteLine($"Apskritimo ilgis yra {2*Pi * Radius }");
            Console.ReadKey();*/


            /*   int DistanceInMeters = Convert.ToInt32(Console.ReadLine());
               Console.ReadKey();
               int TimeInSeconds = Convert.ToInt32(Console.ReadLine());
               Console.ReadKey();
               Console.WriteLine($"Greitis kilais per valanda yra {DistanceInMeters/1000/TimeInSeconds/360}");
               Console.ReadKey();*/

            /*int test = 10;
            int test2 = test++;
            int test3 = ++test;
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine(test+=5);*/

            /*   Console.WriteLine("Iveskite pirma skaiciu");

               int FirstDigit = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Iveskite antra skaiciu");

               int SecondDigit = Convert.ToInt32(Console.ReadLine());

               if (FirstDigit > SecondDigit)
               {
                   Console.WriteLine("pirmas skaicius idesnis uz antra");
               }
               else if (FirstDigit < SecondDigit)
               {
                   Console.WriteLine("pirmas skaicius mazesnis uz antra");
               }
               else if (FirstDigit == SecondDigit)
               {
                   Console.WriteLine("skaiciai lygus");
               }

               Console.ReadKey();*/

            /*    Console.WriteLine("Iveskite pazymi");

                int Grade = Convert.ToInt32(Console.ReadLine());



                if (Grade == 10)
                {
                    Console.WriteLine("perfect");
                }
                else if (Grade < 10 && Grade >7)
                {
                    Console.WriteLine("sehr gut");
                }
                else if (Grade <= 7 && Grade > 5)
                {
                    Console.WriteLine("gut");
                }
                else if (Grade == 5)
                {
                    Console.WriteLine("middle man ");
                }
                else if (Grade == 4)
                {
                    Console.WriteLine("bent teigiamas");
                }
                else if (Grade < 4 && Grade > 0)
                {
                    Console.WriteLine("very bad");
                }
                else
                {
                    Console.WriteLine("wrong grade");
                }

                Console.ReadKey();*/

            /*    Console.WriteLine("Iveskite pirma skaiciu");
                int FirstDigit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Iveskite antra skaiciu");
                int SecondDigit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Iveskite trecia skaiciu");
                int ThirdDigit = Convert.ToInt32(Console.ReadLine());

                int Sum = FirstDigit + SecondDigit + ThirdDigit;
                int Difference = FirstDigit - ThirdDigit;
                int Multiply = SecondDigit * ThirdDigit;
                switch (FirstDigit)
                {
                    case 1:
                        Console.WriteLine($"Skaiciu suma yra :{Sum}");
                        break;
                    case 2:
                        Console.WriteLine($"Pirmo ir trecio skaiciu skirumas yra:{Difference}");
                        break;
                    case 3:
                        Console.WriteLine($"Antro ir trecio skaiciu sandauga yra:{Multiply}");
                        break;
                    default:
                        Console.WriteLine("Pirmas skaicius yra didesnis nei 3 arba mazesnis uz 1");
                        break;

                }*/

            /*  Console.WriteLine("Iveskite skaiciu");
              int FirstDigit = Convert.ToInt32(Console.ReadLine());
              switch (FirstDigit)
              {
                  case 1:
                      Console.WriteLine("Jus pasirinkote limonada");
                      break;
                  case 2:
                      Console.WriteLine("Jus pasirinkote arbata");
                      break;
                  case 3:
                      Console.WriteLine("Jus pasirinkote kakava");
                      break;
                  case 4:
                      Console.WriteLine("Jus pasirinkote kava");
                      break;
                  case 5:
                      Console.WriteLine("Jus nieko nepasirinkote");
                      break;
                  default:
                      Console.WriteLine("Blogai pasirinktas skaicius");
                      break;

              }*/

            /*Console.WriteLine("Iveskite kiek darbuotojas iskepa per 1 valanda");
            int OneEmployeePerformance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek darbuotoju turi kepimo irengimus");
            int Employees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo savikaina");
            int Cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina");
            int UnitSalePrice = Convert.ToInt32(Console.ReadLine());
            const int HoursPerDay = 8;

            int BakeryDayPerformance = OneEmployeePerformance * Employees * HoursPerDay;
            int BakeryDayCost = BakeryDayPerformance * Cost;
            int BakeryDayIncome = BakeryDayPerformance * UnitSalePrice;
            int BakeryDayProfit = BakeryDayIncome - BakeryDayCost;

            Console.WriteLine($"Kepykla per diena iskepe {BakeryDayPerformance} kepalu");
            Console.WriteLine($"Kepyklos iskeptu kepalu dienos savikaina :{BakeryDayCost}");
            Console.WriteLine($"Kepyklos dienos apyvarta:{BakeryDayIncome}");
            Console.WriteLine($"Kepyklos dienos pelnas:{BakeryDayProfit}");*/


            /*  for (int i = 0; i <=20; i+=3)
              {
                  Console.WriteLine(i);
              }*/

            /*  Console.WriteLine("Iveskite pirma skaiciu");
              int indexOne = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Iveskite antra skaiciu");
              int indexTwo = Convert.ToInt32(Console.ReadLine());

              if (indexTwo <= indexOne)
              {
                  Console.WriteLine("bad limits");
              }
              else
              {
                  for (int i = indexOne; i<= indexTwo; i++)
                  {
                      Console.WriteLine(i);
                  }
              }*/
            /*int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);*/
            /*     const int Passengers = 8;
                 const int PassengersNearWindow = 4;
                 const int PassengerRegular = 4;


                 int i = 0;
                 int input = 0;
                 do
                 {
                     if (input <= PassengersNearWindow)
                     {
                         Console.WriteLine("Ar sedesite prie lango? 1-Taip, 0-Ne");
                         input = Convert.ToInt32(Console.ReadLine());
                         i += input;
                         Console.WriteLine(i);
                         Console.WriteLine(input);
                     }
                     else
                     {
                         Console.WriteLine("prie lango uzimtos vietos");
                         input = Convert.ToInt32(Console.ReadLine());
                         i += input;
                     }

                 }
                 while
                 (
                 i < Passengers
                 );*/

            Console.WriteLine();
            int digit = 6;

            Console.WriteLine(increase(ref digit));
            Console.WriteLine(digit);

        }
        static int  increase(ref int a)
        {
            return a++;
        }
    }
}
