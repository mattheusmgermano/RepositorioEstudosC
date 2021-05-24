using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Maria de Lourdes";
            int idade = 99;
            double _saldo = 2500.123456789;
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(_saldo.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
