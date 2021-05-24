using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_CSharpCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
                {
                    new Mes("Janeiro", 31), new Mes("Fevereiro", 28),new Mes("Março", 31),
                    new Mes("Abril", 30), new Mes("Maio", 31), new Mes("Junho", 30),
                    new Mes("Julho", 31),new Mes("Agosto", 31),new Mes("Setembro", 30),
                    new Mes("Outubro", 31),new Mes("Novembro", 30),new Mes("Dezembro", 31)
                };
            //PROBLEMA: OBTER O PRIMEIRO TRIMESTRE
            var consulta = meses.Take(3);

            //PROBLEMA: PEGAR OS MESES DEPOIS DO PRIMEIRO TRIMESTRE
            var consulta2 = meses.Skip(3);

            //PROBLEMA: PEGAR OS MESES DO SEGUNDO TRIMESTRE
            var consulta3 = meses.Skip(3)
                                    .Take(3);
            //PROBLEMA: PEGAR OS MESES QUE COMECEM COM A LETRA 'S'
            var consulta4 = meses.Where(m => m.Nome.StartsWith('S'));

            //PROBLEMA: PEGAR OS MESES DO TERCEIRO TRIMESTRE:
            var consulta5 = meses.Skip(6)
                                    .Take(3);
            //PROBLEMA: PEGAR OS MESES QUE VÃO ATÉ O MÊS QUE COMECE COM A LETRA 'S'
            var consulta6 = meses.TakeWhile(m => !m.Nome.StartsWith('S'));

            //PROBLEMA: PEGAR OS MESES APÓS O MÊS QUE COMEÇA COM A LETRA 'S'
            var consulta7 = meses.SkipWhile(m => !m.Nome.StartsWith('S'));

            Imprimir(consulta7);

        }

        private static void Imprimir(IEnumerable<Mes> consulta)
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
