using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_CSharpCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA: OBTER OS NOMES DOS MESES DO ANO
            //QUE TEM 31 DIAS, EM MAIÚSCULO E ORDENADOS PELO ALFABETO
            List<Mes> meses = new List<Mes>
                {
                    new Mes("Janeiro", 31), new Mes("Fevereiro", 28),new Mes("Março", 31),
                    new Mes("Abril", 30), new Mes("Maio", 31), new Mes("Junho", 30),
                    new Mes("Julho", 31),new Mes("Agosto", 31),new Mes("Setembro", 30),
                    new Mes("Outubro", 31),new Mes("Novembro", 30),new Mes("Dezembro", 31)
                };

            //LINQ = CONSULTA INTEGRADA A LINGUAGEM
            IEnumerable<string>
                consulta = meses
                    .Where(m => m.Dias == 31)
                        .OrderBy(m => m.Nome)
                            .Select(m => m.Nome.ToUpper()); //não é possível converter implicitamente string em Mes
                                                            //para isso, devemos mudar o tipo para string. Já que é                       //ela que nos interessa.

            //PROBLEMA: SEPARAR OS MESES POR TRIMESTRE


        }

        private static void Imprimir(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Mes : IComparable
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public int CompareTo(object obj)
        {
            Mes mes = obj as Mes;
            return this.Nome.CompareTo(mes.Nome);
        }

        public override string ToString()
        {
            return $"{Nome}, {Dias} dias";
        }
    }


}
