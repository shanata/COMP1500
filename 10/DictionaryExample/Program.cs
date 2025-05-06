using System;
using System.Collections.Generic;

namespace  DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(0, 10);
                list.Add(number);

            }

            Console.WriteLine($"[ {string.Join(", ", list)} ]");
            Console.WriteLine("");

            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();

            for (int i = 0; i < list.Count; i++)
            {
                if (dictionary.ContainsKey(list[i]))
                {
                    list.Remove(list[i]);
                    i--;
                    Console.WriteLine($"Removed {list[i]} from list");
                    Console.WriteLine($"[ {string.Join(", ", list)} ]");
                    Console.WriteLine("");
                    
                }
                else
                {
                    dictionary.Add(list[i], true);
                    Console.WriteLine($"Added {list[i]} to dictionary");
                    Console.WriteLine($"[ {string.Join(", ", list)} ]");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine($"[ {string.Join(", ", list)} ]");
        }
    }
}