using System;
using System.Drawing;


//Problem 10. Point Inside a Circle & Outside of a Rectangle
namespace PointInCircleAndOutsideRectangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter x  : ");

            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y  : ");

            double y = double.Parse(Console.ReadLine());

            double centerX = 1, centerY = 1;

            double radius = Math.Pow(1.5, 2);

            double point = Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2);

            bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("The point is not in the circle and out of the rectangle");
            }

            if (isOutsideRectangle == true && point < radius)
            {
                Console.WriteLine("The point is in the circle and out of the rectangle");
            }

            Console.WriteLine("The point is not in the circle and out of the rectangle");
        }
    }
}
