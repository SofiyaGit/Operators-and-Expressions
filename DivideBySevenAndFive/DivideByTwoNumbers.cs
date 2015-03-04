using System;

//Problem 3. Divide by 7 and 5
namespace DivideBySevenAndFive
{
    class DivideByTwoNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");

            string enteredNumber = Console.ReadLine();

            //convert string to int
            int number = int.Parse(enteredNumber);

            if (number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Divided by 7 and 5 ? It's : {0}", true);
            }

            else 
            {
                Console.WriteLine("Divided by 7 and 5 ? It's : {0}", false);
            }
        }
    }
}
