using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OPERADORES ARITMÉTICOS
             * ADIÇÃO = +
             * SUBTRAÇÃO = -
             * [PRECEDÊNCIA MAIOR] MULTIPLICAÇÃO´= *
             * [PRECEDÊNCIA MAIOR] DIVISÃO = /
             * RESTO DA DIVISÃO = %
             */

            int res = 3 + 4 * 2; // MULTIPLICAÇÃO TEM PRECEDÊNCIA ENTÃO SERÁ EFETUADA 1º
            Console.WriteLine(res);
            res = (3 + 4) * 2; // UTILIZAR PARÊNTESES PARA QUEBRAR PRECEDÊNCIA
            Console.WriteLine(res);

            // FÓRMULA DE BHASKARA
            double a = 5.0, b = -4.0, c = - 7.0;
            double delta = Math.Pow(b, 2) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"{x1:2} e {x2:2}");
        }
    }
}
