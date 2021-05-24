using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    class Designer : Funcionario {
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, 3000) {
            Console.WriteLine("Criando DESIGNER");
        }

        public override double GetBonificacao() {
            return Salario * 0.15;
        }
        public override void AumentarSalario() {
            Salario *= 1.11;
        }
    }
}
