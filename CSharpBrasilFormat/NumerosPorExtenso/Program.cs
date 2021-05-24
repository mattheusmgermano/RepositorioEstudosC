using Caelum.Stella.CSharp.Inwords;
using System;
using System.Diagnostics;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string valorExtenso = new Numero(valor).Extenso();
            Debug.WriteLine($"{valor}: {valorExtenso}");
            //
            valor = 1500999.10;
            valorExtenso = new Numero(valor).Extenso();
            Debug.WriteLine($"{valor}: {valorExtenso}");

            var dinheiros = new MoedaBRL(valor).Extenso();
            Console.WriteLine(dinheiros);

        }
    }
}
