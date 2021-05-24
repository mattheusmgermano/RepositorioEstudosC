using System;

namespace ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, f, g;
            float a, d;
            double b, c, h;

            // CONVERSÃO IMPLÍCITA
            a = 4.75f;  // 4 BYTES
            b = a;  // 8 BYTES
            Console.WriteLine(b);

            // CASTING
            c = 4.75; // 8 BYTES
            d = (float)c; // 4 BYTES
            Console.WriteLine(d);
            //Ao usar o casting, eu digo para o compilador que não
            //há problema em perder um pouco de informação.

            e = (int)c; // Integer é um número inteiro
                        //Ao usar casting neste tipo de variável, tudo após o ponto será perdido.

            f = 5;
            g = 2;
            h = f / g;
            Console.WriteLine(h);  // O compilador interpretará a divisão entre f e g
                                   // como uma operação de inteiros com resultado inteiro
                                   // para transformar este valor em double de fato é 
                                   // necessário aplicar o casting no início da operação

            h = (double)f / g;
            Console.WriteLine(h);


        }
    }
}
