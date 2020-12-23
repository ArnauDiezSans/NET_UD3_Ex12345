using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x=2, y=5;
            double n=1.52, m=3.06;

            Console.WriteLine("El valor de cada variable x:{0}, y{1}, n:{2}, m:{3}",x,y,n,m);
            Console.WriteLine("La suma X + Y: {0}", x+y);
            Console.WriteLine("La diferencia X – Y: {0}", x - y);
            Console.WriteLine("El producto X * Y: {0}", x * y);
            Console.WriteLine("El cociente X / Y: {0}", x / y);
            Console.WriteLine("El resto X % Y: {0}", x % y);
            Console.WriteLine("La suma N + M: {0}", n + m);
            Console.WriteLine("La diferencia N – M: {0}", n - m);
            Console.WriteLine("El producto N * M: {0}", n * m);
            Console.WriteLine("El cociente N / M: {0}", n / m);
            Console.WriteLine("El resto N % M: {0}", n % m);
            Console.WriteLine("La suma X + N: {0}", x + n);
            Console.WriteLine("El cociente Y / M: {0}", y / m);
            Console.WriteLine("El resto Y % M: {0}", y % m);
            Console.WriteLine("El valor doble de cada variable x:{0}, y{1}, n:{2}, m:{3}", x*2, y*2, n*2, m*2);
            Console.WriteLine("El producto X * Y * N * M: {0}", x * y * n * m);


        }
    }
}
