using System;

//Problem 9. Trapezoids
namespace Trapezoids
{
    class AreaTrapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter a  : ");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b  : ");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter h  : ");

            double h = double.Parse(Console.ReadLine());

             double area = ((a + b) / 2) * h;

             Console.WriteLine("The area is : {0}", area);
        }
    }
}
