using System;
using System.Globalization;

namespace Curso2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Maria de Lourdes";
            int idade = 99;
            float saldo = 9500f;
            Console.WriteLine(nome + " tem " + idade + " anos e possui saldo de R$" + saldo.ToString("F2", CultureInfo.InvariantCulture)); //Concatenação
            Console.WriteLine("{0} tem {1} anos e possui saldo de R${2:F2}", nome, idade, saldo); //Placeholder
            Console.WriteLine($"{nome} tem {idade} anos e possui saldo de R$ {saldo:F2}."); //Interpolação

        }
    }
}
