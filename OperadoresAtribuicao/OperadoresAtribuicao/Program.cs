using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine(a);
            a += 10;  // A = A + 10
            Console.WriteLine(a);
            a -= 5;  // A = A - 5
            Console.WriteLine(a);
            a *= 2;  // A = A * 2
            Console.WriteLine(a);
            a /= 3; // A = A / 2
            Console.WriteLine(a);
            a %= 2;  // A = A % 2
            Console.WriteLine(a);
            /* OPERADORES ARITMÉTICOS / ATRIBUIÇÃO */
            int b = 10;
            int c = b++;
            Console.WriteLine(b);
            Console.WriteLine(c);
            b = 10;
            c = ++b;
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
