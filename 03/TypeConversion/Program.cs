﻿using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = 'a';

            int int1 = char1;
            long long1 = char1;
            ulong ulong1 = char1;
            float float1 = char1;
            double double1 = char1;

            long long2 = long.MaxValue;
            int long2ToInt = (int)long2;

            float float2 = 3.14159f;
            int float2ToInt = (int)float2;

            int int2 = -1;
            uint int2ToUInt = (uint)int2;

            Console.WriteLine("int1: " + int1);
            Console.WriteLine("long1: " + long1);
            Console.WriteLine("ulong1: " + ulong1);
            Console.WriteLine("float1: " + float1);
            Console.WriteLine("double1: " + double1);

            Console.WriteLine("long2: " + long2);
            Console.WriteLine("long2ToInt: " + long2ToInt);

            Console.WriteLine("float2: " + float2);
            Console.WriteLine("float2ToInt: " + float2ToInt);

            Console.WriteLine("int2ToUInt: " + int2ToUInt);
        }
    }
}