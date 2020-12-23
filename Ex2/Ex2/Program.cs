using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int N = 2;
            double A = 1.52;
            char C='a';

            Console.WriteLine("Valor de cada variable N:{0}, A:{1}, C:{2}", N, A, C);
            Console.WriteLine("La suma de N + A:{0}", N + A);
            Console.WriteLine("La diferencia de N - A:{0}", N - A);
            Console.WriteLine("El valor numérico de C:{0}", (int) C);
        }
    }
}
