using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank {
    public class SaldoInsuficienteException : OperacaoFinanceiraException {

        public SaldoInsuficienteException() {
        }
        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Operação no valor de R$" + valorSaque + " em uma conta com saldo de R$"+ saldo) {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException (string mensagem) : base(mensagem) {
        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) {
        }
        public double Saldo { get; }
        public double ValorSaque { get; }
    }
}
