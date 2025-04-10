using System;

namespace BitFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0;

            byte mask1 = 1 << 2;

            bitFlags |= mask1;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            byte mask3 = (1 << 3) | (1 << 5);
            bitFlags |= mask3;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            bitFlags &= (byte)~mask1;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            bitFlags &= 0;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            char char1 = 'A';
            int result1 = char1 | ' ';
            Console.WriteLine("bitFlags: " + Convert.ToString(char1, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            Console.WriteLine("bitFlags: " + Convert.ToString(' ', 2).PadLeft(BIT_FLAG_SIZE, '0'));
            Console.WriteLine("result1: " + (char)result1);
            char char2 = 'a';
            int result2 = char2 & '_';
            Console.WriteLine("bitFlags: " + Convert.ToString(char2, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            Console.WriteLine("bitFlags: " + Convert.ToString('_', 2).PadLeft(BIT_FLAG_SIZE, '0'));
            Console.WriteLine("result2: " + (char)result2);
        }
    }
}