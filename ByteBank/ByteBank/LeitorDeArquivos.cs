using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ByteBank {
    public class LeitorDeArquivo : IDisposable {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo) {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
            //throw new FileNotFoundException();
        }

        public string LerProximaLinha() {
            Console.WriteLine("Lendo linha...");
            throw new IOException();
            //return "Linha do Arquivo";
        }
        public void Dispose() {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}