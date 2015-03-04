using System;

//Problem 2. Gravitation on the Moon
namespace GravitationOnTheMoon
{
    class CalculateWeight
    {
        static void Main()
        {
            Console.WriteLine("Enter a weight - 0,00 or 0 : ");

            string inputWeight = Console.ReadLine();

            float weight = float.Parse(inputWeight);

            float weightOnMoon = (weight*17)/100;

            Console.WriteLine("The weight on the moon is : {0}", weightOnMoon);
        }
    }
}

