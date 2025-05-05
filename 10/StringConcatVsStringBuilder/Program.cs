using System;
using System.Text;
using System.Diagnostics;


namespace StringConcatVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LOOP_COUNT = 100000;

            Stopwatch stopWatch = new Stopwatch();

            #region USING_CONCATENATION
            stopWatch.Start();

         
            string concatenated = string.Empty;
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                concatenated += "test";
            }

            stopWatch.Stop();
            Console.WriteLine($"Time elapsed in ms (Concatenated): {stopWatch.Elapsed.TotalMilliseconds}");
            #endregion

            stopWatch.Reset();

            #region USING_STRING_BUILDER
            stopWatch.Start();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < LOOP_COUNT; i++)
            {
                stringBuilder.Append("test");
            }
            string result = stringBuilder.ToString();
            stopWatch.Stop();   
            Console.WriteLine($"Time elapsed in ms (StringBuilder): {stopWatch.Elapsed.TotalMilliseconds}");
            #endregion
        }
    }
}