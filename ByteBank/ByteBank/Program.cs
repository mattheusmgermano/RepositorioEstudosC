using ByteBank.Funcionarios;
using System;
using System.Globalization;
using System.IO;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            try {
                CarregarContas();
            }
            catch(Exception e) {
                Console.WriteLine("CATCH NO METODO MAIN");
            }
            
        }
        private static void CarregarContas() {

            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt")) {
                leitor.LerProximaLinha();
            }
            //LeitorDeArquivo leitor = null;
            //try {
            //    leitor = new LeitorDeArquivo("conta2.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException) {
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally {
            //    leitor.Fechar();
            //}
        }
    }
}
