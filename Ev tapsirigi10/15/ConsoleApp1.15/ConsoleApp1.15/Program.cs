using System;

namespace ConsoleApp1._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
 Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
 Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
 Sonra alinan cavabin ustune gel 6 reqemli ededi.
 Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
 Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
 Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel. */

            int a = 123;
            int b = 234;
            int c = 3456;
            int s = 4567;
            int d = 65662;
            int e = 21384;
            int x = 566556;

            long q = (a + b + (c * s)) * 10 + 7 + d + e;
            long f = q - (a * b * 10 + 1) + x;
            double g = (f - a + b + c + s) * 18 / 100.0;
            double h = g * 3 / 100.0;
            double i = h * 1 / 100.0;
            double j = i + d + e;


            Console.WriteLine(j);





        }
    }
}
