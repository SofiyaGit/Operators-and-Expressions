using System;

//Problem 11. Bitwise: Extract Bit #3
namespace ExtractBit3
{
    class TakeABit
    {
        static void Main()
        {
            

            Console.WriteLine("Enter number  : ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            int position = 3;

            int mask = 1 << position;

            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

            int numberAndMask = number & mask;

            Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(16, '0'));

            int bit = numberAndMask >> position;

            Console.WriteLine("The bit is : {0}", bit);
        }
    }
}
