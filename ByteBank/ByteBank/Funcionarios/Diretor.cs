using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    class Diretor : FuncionarioAutenticavel {

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario) {
            Console.WriteLine("Criando DIRETOR");
        }
        public override double GetBonificacao() {
            return Salario * 0.20;
        }
        public override void AumentarSalario() {
            Salario *= 1.15;
        }
    }
}
