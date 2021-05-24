using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    public abstract class Funcionario {
        public Funcionario(string nome, string cpf, double salario) {
            Console.WriteLine("Criando FUNCIONÁRIO");
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }
        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }


        public static int TotalFuncionarios { get; private set; }


        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
