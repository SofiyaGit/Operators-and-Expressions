using System;

//Problem 12. Extract Bit from Integer
namespace ExtractBitInteger
{
    class ExtractBitFromInt
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

            Console.WriteLine("The bit is : {0}", bit);
        }
    }
}
