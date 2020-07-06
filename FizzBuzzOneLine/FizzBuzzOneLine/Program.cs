using System;

namespace FizzBuzzOneLine
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{((i % 3 == 0) ? "Fizz " : "")}" +
                                  $"{((i % 5 == 0) ? "Bizz " : "")}" +
                                  $"{((!(i % 5 == 0) && !(i % 3 == 0)) ? i.ToString() : "")}");
            }
        }
    }
}
