using System;
using System.Globalization;

namespace EntradaDados02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            char ch;
            double n2;
            n1 = int.Parse(Console.ReadLine());
            ch = char.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"{n1}, {n2} e {ch}");
            String[] vet = Console.ReadLine().Split(' ');
            String nome = vet[0];
            int idade = int.Parse(vet[2]);
            char sexo = char.Parse(vet[1]);
            float altura = float.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine($"[{nome}] é do sexo [{sexo}], tem [{idade}] anos e mede [{altura}] metros.");

        }
    }
}
