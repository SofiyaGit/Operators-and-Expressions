using System;

//Problem 4. Rectangles
namespace Rectangles
{
    class PerimeterArea
    {
        static void Main()
        {
            Console.WriteLine("Enter a widht : ");

            string enteredWidht = Console.ReadLine();

            //convert string to int
            int width = int.Parse(enteredWidht);

            Console.WriteLine("Enter a height : ");

            string enteredHeight = Console.ReadLine();

            int height = int.Parse(enteredHeight);;

            int perimeter = 2 * (width + height);

            int area = width * height;

            Console.WriteLine("The perimeter is : {0}", perimeter);

            Console.WriteLine("The area is : {0}", area);
        }
    }
}
