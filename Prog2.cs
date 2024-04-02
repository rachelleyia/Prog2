using System;

namespace Prog2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 100; n++)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}