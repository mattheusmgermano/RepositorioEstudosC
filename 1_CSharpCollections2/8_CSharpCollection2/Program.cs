using System;
using System.Collections.Generic;

namespace _8_CSharpCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Covariância");
            Console.WriteLine("String para object: ");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);
            Console.WriteLine();
            //A conversão compila porque String herda de Object.
            Console.WriteLine("List<string> para List<object>:");
            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            //IList<object> listaObj = listaMeses;
            Console.WriteLine();

            Console.WriteLine("string[] para object[]");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObject = arrayMeses; //COVARIÂNCIA
            Console.WriteLine(arrayObject);
            Imprimir(arrayObject);
            arrayObject[0] = "Primeiro Mês";
            //arrayObject[0] = 12345;
            //Console.WriteLine(arrayObject[0]);
            Console.WriteLine();

            Console.WriteLine("List<string> para IEnumerable<object>");

            IEnumerable<object> enumObj = listaMeses;
            foreach(var item in enumObj)
            {
                Console.WriteLine(item);
            }
        }

        private static void Imprimir(object[] arrayObject)
        {
            foreach (var item in arrayObject)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
