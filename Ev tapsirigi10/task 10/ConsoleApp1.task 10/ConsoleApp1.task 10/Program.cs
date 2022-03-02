using System;

namespace ConsoleApp1.task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 dene 4 reqemli eded verilib.I ededin 1 % -ni, II ededin 2 % , III ededin 3 % tap.
 Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel */

            int a = 1234;
            int b = 2345;
            int c = 3456;

            double d = a * 1 / 100.0;



            double e = b * 2 / 100.0;

              double f = c * 3 / 100.0;
               double g = c * 7 / 100.0;

            double h = d - e - f + g;
            Console.WriteLine(h);





        }




    }
}
