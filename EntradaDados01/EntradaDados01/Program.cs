using System;

namespace EntradaDados01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine()
            //Lê da entrada padrão à quebra de linha (enter pressionado)
            //Retorna os dados na forma de String
            string frase, a, b, c, d, e, f, g;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            g = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            d = vet[0];
            e = vet[1];
            f = vet[2];

            Console.WriteLine($"Você digitou as cores: {a}, {b}, {c}, {d}, {e}, {f}.");
        }
    }
}
