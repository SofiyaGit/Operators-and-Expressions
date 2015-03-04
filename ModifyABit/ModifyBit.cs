using System;

//Problem 14. Modify a Bit at Given Position
namespace ModifyABit
{
    class ModifyBit
    {
        static void Main()
        {
            Console.WriteLine("Enter number  : ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            Console.WriteLine("Enter position  : ");

            int position = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value  : ");

            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                int mask =  1 << position;       
 
                int numberAndMask = number & mask;

                Console.WriteLine(numberAndMask);

            }
            else
            {
                int mask = 1 << position;

                int numberAndMask = number | mask;

                int bit = numberAndMask >> position;

                Console.WriteLine(numberAndMask);
            }
        }
    }
}
