using System;

namespace FuncaoSintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior foi: "+ resultado);

        }
        static int Maior(int a1, int a2, int a3) {
            if (a1 > a2 && a1 > a3) {
                return a1;
            } else if (a2 > a1 && a2 > a3) {
                return a2;
            } else {
                return a3;
            }

        }
    }
}
