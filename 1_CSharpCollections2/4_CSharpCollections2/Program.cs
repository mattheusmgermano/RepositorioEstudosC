using System;

namespace _4_CSharpCollections2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] familias = new string[3][];
            //{
            //    { "Fred", "Vilma", "Pedrita" },
            //    { "Homer", "Marge", "Lisa", "Bart", "Maggie" },
            //    { "Florinda", "Kiko" }
            //};
            familias[0] = new string[] { "Fred", "Vilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };
            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",", familia));
            }
        }
    }
}
