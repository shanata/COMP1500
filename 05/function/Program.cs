using System;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}] = {args[i]}");
            }
        }
    }
}