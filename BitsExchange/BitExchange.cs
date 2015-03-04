using System;

//Problem 15.* Bits Exchange
namespace BitsExchange
{
    class BitExchange
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("number {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

            // mask out the ones we swap
            int outNumber = number & ~0x07000038;

            // Move the bits 3,4,5 with 21 sections
            outNumber |= (number & 0x00000038) << 21;

            Console.WriteLine("Output number  << 21 {0}", Convert.ToString(outNumber, 2).PadLeft(32, '0'));

            //Move the bits 23,24,25 with 21 sections
            outNumber |= (number & 0x07000000) >> 21;

            Console.WriteLine("Output number  >> 21 {0}", Convert.ToString(outNumber, 2).PadLeft(32, '0'));

            Console.WriteLine(outNumber);


        }
    }
}
