using System;

namespace ConsoleApp1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 dene 6 reqemli eded verilib.Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
 Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap. */

            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 456789;

            double e = (a * 10 / 100.0) + (b * 10 / 100.0) + (c * 10 / 100.0) + (d * 10 / 100.0);
            double f = (a * 15 / 100.0) + (b * 15 / 100.0) + (c * 15 / 100.0) + (d * 15 / 100.0) * e;
            double g = f * 10 / 100.0;
            double h = g * 11 / 100.0;


            Console.WriteLine(h);



        }
    }
}
