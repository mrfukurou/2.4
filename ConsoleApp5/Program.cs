using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++, Console.WriteLine())
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                for (int m = 0; m < i; m++)
                    Console.Write(5 + i + " ");
            }
        }
    }
}
