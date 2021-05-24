using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    class GerenteDeConta : FuncionarioAutenticavel {
        public GerenteDeConta(string nome, string cpf, double salario) : base(nome, cpf, 4000) {
            Console.WriteLine("Criando GERENTE DE CONTA");
        }
        public override double GetBonificacao() {
            return Salario * 0.12;
        }
        public override void AumentarSalario() {
            Salario *= 1.05;
        }
        }
    }
