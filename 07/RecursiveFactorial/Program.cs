using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            const ulong FACTORIAL = 10;

            Console.WriteLine("NonRecursiveFactorial:");
            Console.WriteLine(NonRecursiveFactorial(FACTORIAL));

            Console.WriteLine("RecursiveFactorial:");
            Console.WriteLine(RecursiveFactorial(FACTORIAL));
        }

        // 아래에 타이핑한 함수들을 붙여넣으세요
        static ulong NonRecursiveFactorial(ulong n)
        {
            if (n <= 1)
            {
                return 1;
            }
            
            uint factorial = 1;

            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;

        }
        static ulong RecursiveFactorial(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }

            return RecursiveFactorial(n-1) * n ;
        }
    }
}