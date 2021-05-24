using System;
using System.Collections.Generic;

namespace _1_CSharpCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos criar um dicionário de alunos:
            // VT, Vanessa, 34672
            // AM, Ana, 5617
            // RN, Rafael, 17645
            // WM, Wanderson, 11287

            //IDictionary<string, Aluno> alunos
            //    = new Dictionary<string, Aluno>();
            //alunos.Add("VT", new Aluno("Vanessa", 34672));
            //alunos.Add("AM", new Aluno("Ana", 5617));
            //alunos.Add("RN", new Aluno("Rafael", 17645));
            //alunos.Add("WM", new Aluno("Wanderson", 11287));

            ////Imprimindo...
            //Imprimir(alunos);
            //Console.WriteLine("");

            //alunos.Remove("AM");
            //alunos.Add("MO", new Aluno("Marcelo", 12345));

            //Imprimir(alunos);

            IDictionary<string, Aluno> sorted 
                = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AM", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            IDictionary<string, Aluno> sortedDict
    = new SortedDictionary<string, Aluno>();
            sortedDict.Add("VT", new Aluno("Vanessa", 34672));
            sortedDict.Add("AM", new Aluno("Ana", 5617));
            sortedDict.Add("RN", new Aluno("Rafael", 17645));
            sortedDict.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(sortedDict);
            Console.WriteLine("");
            Imprimir(sorted);



        }

        private static void Imprimir(IDictionary<string, Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("");
        }
    }
}
