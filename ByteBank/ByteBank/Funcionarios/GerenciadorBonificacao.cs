using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    class GerenciadorBonificacao {
        private static double _totalBonificacao;

        public static void Registrar (Funcionario funcionario) {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao() {
            return _totalBonificacao;
        }
    }
}
