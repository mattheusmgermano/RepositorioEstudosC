using Caelum.Stella.CSharp.Http;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            var cep = "90670001";
            var url = "https://viacep.com.br/ws/" + cep + "/json/";
            //var result = new HttpClient().GetStringAsync(url).Result;
            //Debug.WriteLine(result);
            //Console.WriteLine(result);

            //var enderecoJson = new ViaCEP().GetEnderecoJson(cep);
            //Debug.WriteLine(enderecoJson);

            var enderecoXML = new ViaCEP().GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXML);

            var enderecoJsonAsync = new ViaCEP().GetEnderecoJsonAsync(cep);
            Debug.WriteLine(enderecoJsonAsync.Result);
            var endereco = GetEndereco(cep);
            Debug.WriteLine(string.Format($"Logradouro {endereco.Logradouro}, bairro {endereco.Bairro}"));

        }

        private static Endereco GetEndereco(string cep)
        {
            return new ViaCEP().GetEndereco(cep);
        }
    }
}
