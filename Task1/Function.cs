using System;

namespace Task1
{
    public class Function
    {
        public static void GetValue(int a, int b, int c)
        {
            Console.WriteLine(2 * Math.Sin(a) + 3 * b * Math.Pow(Math.Cos(c), 3));
        }
    }
}
