using System;

namespace EscopoInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dê um preço para desfigurador anatômico sapatílhico: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("E quantos você quer comprar? ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade > 5){ // Escopo do IF
                double desconto = (valor * quantidade) * 0.05;  // variável desconto existe apenas aqui
                Console.WriteLine($"{quantidade} desfiguradores anatômicos sapatílhicos\n" +
                    $"saem com 5% de desconto! O valor total é de apenas R$" + ((valor * quantidade) - desconto));
            } else { // Fim do escopo do IF, início do escopo Else
                Console.WriteLine($"{quantidade} desfigurador(es) anatômico(s) sapatílhico(s)!\n" +
                    $" O valor total é de apenas R$" + (valor * quantidade));

            }
        }
    }
}
