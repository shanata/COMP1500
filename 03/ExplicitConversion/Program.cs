using System;
using System.Runtime.CompilerServices;

namespace ExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.9;
            double num2 = 52.16;

            Console.WriteLine("일반 덧셈 결과: " + (num1 + num2));

            int result = (int)num1 + (int)num2;
            Console.WriteLine("명시적 형변환 덧셈 결과: " + result);

            float num3 = 10.9f;
            float num4 = 52.16f;

            Console.WriteLine("일반 덧셈 결과: " + (num3 + num4));

            int result2 = (int)num3 + (int)num4;
            Console.WriteLine("명시적 형변환 덧셈 결과: " + result2);
            Console.ReadLine();
        }
    }
}