using System;

namespace ConsoleApp1.task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 reqemli eded verilib.Bu ededin evvel 18 % sonra ise 3 % tap */

            int a = 12345;
            double b = 12345 * 18 / 100.0;
            double c = b * 3 / 100.00;

            Console.WriteLine(c);
        }
    }
}
