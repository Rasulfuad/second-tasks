using System;

namespace ConsoleApp1.task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  4 reqemli eded verilib.Bu ededin evvel 20 % -ni , sonra ise cavabin 10 % tap.Alinan cavabin kvadratini tap */

            int a = 2345;
            double b = a * 20.0 / 100.0 * 10.0 / 100.0;
            double c = b * b;
            Console.WriteLine(c);
        }
    }
}
