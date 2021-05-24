using System;
using System.Collections.Generic;

namespace _2_CSharpCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //conjunto de alunos
            ISet<string> alunos
            = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };
            //adicionar Rafael Rollo
            alunos.Add("Rafael Rollo");
            //adicionar Fabio Gushiken
            alunos.Add("Fábio Gushiken");
            //adicionar Fábio Gushiken outra vez
            alunos.Add("Fábio Gushiken");
            //adicionar FÁBIO GUSHIKEN
            alunos.Add("FÁBIO GUSHIKEN");
            Imprimir(alunos);

            Console.Clear();

            ISet<string> outroConjunto
                = new HashSet<string>();

            //este conjunto é subconjunto do outro?
            alunos.IsSubsetOf(outroConjunto);
            //este conjunto é superconjunto do outro?
            alunos.IsSupersetOf(outroConjunto);
            //os conjuntos contém os mesmos elementos?
            alunos.SetEquals(outroConjunto);
            //subtrair os elementos de outra coleção que também estão no mesmo conjunto
            alunos.ExceptWith(outroConjunto);
            //intersecção dos conjuntos
            alunos.IntersectWith(outroConjunto);
            //elementos somente em um ou outro conjunto
            alunos.SymmetricExceptWith(outroConjunto);
            //unindo conjuntos
            alunos.UnionWith(outroConjunto);
        }

        private static void Imprimir(ISet<string> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
