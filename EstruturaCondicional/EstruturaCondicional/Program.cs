using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            if (num%2 == 0) {
                Console.WriteLine($"O número {num} é par.");
            } else {
                Console.WriteLine($"O número {num} é ímpar.");
            }
        }
    }
}
