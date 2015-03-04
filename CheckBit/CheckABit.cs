using System;

//Problem 13. Check a Bit at Given Position
namespace CheckBit
{
    class CheckABit
    {
        static void Main()
        {
            Console.WriteLine("Enter number  : ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            Console.WriteLine("Enter position  : ");

            int position = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(position, 2).PadLeft(16, '0'));

            int mask = 1 << position;

            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

            int numberAndMask = number & mask;

            Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(16, '0'));

            int bit = numberAndMask >> position;

            if (bit == 1 )
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
