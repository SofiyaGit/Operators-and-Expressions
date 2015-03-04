using System;

//Problem 5. Third Digit is 7?
namespace ThirdDigitSeven
{
    class DigitSeven
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");

            int number = int.Parse(Console.ReadLine());

            number /= 100;

            number = number % 10;

            if (number == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
          
        }
    }
}
