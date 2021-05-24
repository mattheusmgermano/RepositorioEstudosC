using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    class Auxiliar : Funcionario {
        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, 2000) {
            Console.WriteLine("Criando AUXILIAR");
        }

        public override double GetBonificacao() {
            return Salario * 0.10;
        }
        public override void AumentarSalario() {
            Salario *= 1.10;
        }
    }
}
