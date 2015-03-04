using System;

//Problem 7. Point in a Circle
namespace PointInACircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter x  : ");

            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y  : ");

            double y = double.Parse(Console.ReadLine());

            double centerX=0 ,centerY = 0;

            double radius = Math.Pow(2,2);

            //using a method .Pow instead of the second degree
            double point = Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2);


            if (point <= radius)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point is not in the circle");
            }
        }
    }
}
