using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using Caelum.Stella.CSharp.Validation.Error;
using System;
using System.Diagnostics;

namespace CSharpBrasilFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpf1 = "86288366757";
            var cpf2 = "8745366797";
            var cpf3 = "22222222222";
            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            //

            string cnpj1 = "51241758000152";
            string cnpj2 = "14128481000120";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            //

            string titulo1 = "041372570132";
            string titulo2 = "774387480132";

            ValidarTitulo(titulo2);
            ValidarTitulo(titulo2);

            //

            Debug.WriteLine(cpf1);
            string cpfFormatado = new CPFFormatter().Format(cpf1);
            Console.WriteLine(cpfFormatado);
            string cpfDesformatado = new CPFFormatter().Unformat(cpfFormatado);
            Console.WriteLine(cpfDesformatado);

            //

            string cnpjFormatado = new CNPJFormatter().Format(cnpj1);
            Console.WriteLine(cnpjFormatado);
            string cnpjDesformatado = new CNPJFormatter().Unformat(cnpjFormatado);
            Console.WriteLine(cnpjDesformatado);

            //

            string teFormatado = new TituloEleitoralFormatter().Format(titulo1);
            Console.WriteLine(teFormatado);
            string teDesformatado = new TituloEleitoralFormatter().Unformat(teFormatado);
            Console.WriteLine(teDesformatado);


        }

        private static void ValidarCPF(string cpf)
        {
            //try
            //{
            //    new CPFValidator().AssertValid(cpf);
            //    Debug.WriteLine("CPF Válido: " + cpf);
            //}
            //catch (InvalidStateException exc)
            //{
            //    Debug.WriteLine($"Este CPF é inválido [{exc.ToString()}]");
            //}

            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF Válido: " + cpf);
            } else
            {
                Debug.WriteLine("Este CPF é inválido.");
            }
        }
        private static bool ValidarCNPJ(string cnpj)
        {
            //try
            //{
            //    new CPFValidator().AssertValid(cpf);
            //    Debug.WriteLine("CPF Válido: " + cpf);
            //}
            //catch (InvalidStateException exc)
            //{
            //    Debug.WriteLine($"Este CPF é inválido [{exc.ToString()}]");
            //}
                return new CNPJValidator().IsValid(cnpj);
        }
        private static bool ValidarTitulo(string titulo)
        {
            //try
            //{
            //    new CPFValidator().AssertValid(cpf);
            //    Debug.WriteLine("CPF Válido: " + cpf);
            //}
            //catch (InvalidStateException exc)
            //{
            //    Debug.WriteLine($"Este CPF é inválido [{exc.ToString()}]");
            //}

            return new TituloEleitoralValidator().IsValid(titulo);
        }
    }
}
