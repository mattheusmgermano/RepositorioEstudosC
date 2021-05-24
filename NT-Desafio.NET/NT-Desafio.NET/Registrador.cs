using System;
using System.IO;

namespace NT_Desafio.NET
{
    class Registrador
    {
        static void Main(string[] args)
        {

            NovoVendedor();
        }
        static void NovoVendedor()
        {
            if (!File.Exists("vendedores.dat"))
            {
                string resp = "S";
                using (var sw = File.AppendText("vendedores.dat"))
                {
                    while (resp == "S")
                    {
                        Console.WriteLine("Informe o nome do vendedor:");
                        string _nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do vendedor:");
                        string _cpf = Console.ReadLine();
                        Console.WriteLine("Informe o salário do vendedor:");
                        double _salario = double.Parse(Console.ReadLine());
                        sw.WriteLine($"001ç{_cpf}ç{_nome}ç{_salario}\n");
                        sw.Flush();
                        Console.WriteLine("Deseja registrar outro vendedor? S/N");
                        resp = Console.ReadLine();

                    }
                }
            }
        }
        static void NovoCliente()
        {
            if (!File.Exists("clientes.dat"))
            {
                string resp = "S";
                using (var sw = File.AppendText("clientes.dat"))
                {
                    while (resp == "S")
                    {
                        Console.WriteLine("Informe o nome do vendedor:");
                        string _nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do vendedor:");
                        string _cpf = Console.ReadLine();
                        Console.WriteLine("Informe o salário do vendedor:");
                        double _salario = double.Parse(Console.ReadLine());
                        sw.WriteLine($"001ç{_cpf}ç{_nome}ç{_salario}\n");
                        sw.Flush();
                        Console.WriteLine("Deseja registrar outro vendedor? S/N");
                        resp = Console.ReadLine();

                    }
                }
            }
        }
        static void Item()
        {
            if (!File.Exists("item.dat"))
            {
                string resp = "S";
                using (var sw = File.AppendText("item.dat"))
                {
                    while (resp == "S")
                    {
                        Console.WriteLine("Informe o nome do vendedor:");
                        string _nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do vendedor:");
                        string _cpf = Console.ReadLine();
                        Console.WriteLine("Informe o salário do vendedor:");
                        double _salario = double.Parse(Console.ReadLine());
                        sw.WriteLine($"001ç{_cpf}ç{_nome}ç{_salario}\n");
                        sw.Flush();
                        Console.WriteLine("Deseja registrar outro vendedor? S/N");
                        resp = Console.ReadLine();

                    }
                }
            }
        }
        static void NovaVenda()
        {
            if (!File.Exists("venda.dat"))
            {
                string resp = "S";
                using (var sw = File.AppendText("venda.dat"))
                {
                    while (resp == "S")
                    {
                        Console.WriteLine("Informe o nome do vendedor:");
                        string _nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do vendedor:");
                        string _cpf = Console.ReadLine();
                        Console.WriteLine("Informe o salário do vendedor:");
                        double _salario = double.Parse(Console.ReadLine());
                        sw.WriteLine($"001ç{_cpf}ç{_nome}ç{_salario}\n");
                        sw.Flush();
                        Console.WriteLine("Deseja registrar outro vendedor? S/N");
                        resp = Console.ReadLine();

                    }
                }
            }
        }
    }
}
