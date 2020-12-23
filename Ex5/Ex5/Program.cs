using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int a = 1, b = 2, c = 3, d = 4;
            b = c;
            c = a;
            a = d;
            d = b;
        }
    }
}
