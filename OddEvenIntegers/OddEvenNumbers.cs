using System;

//Problem 1. Odd or Even Integers
namespace OddEvenIntegers
{
    class OddEvenNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number : ");

            string number = Console.ReadLine();

            //convert string to int
            int numberToInt = int.Parse(number);

            if (numberToInt % 2 == 0)
            {
                Console.WriteLine("This number is even : {0}", numberToInt);
            }

            else 
            {
                Console.WriteLine("This number is odd : {0}", numberToInt);
            }
        }
    }
}
