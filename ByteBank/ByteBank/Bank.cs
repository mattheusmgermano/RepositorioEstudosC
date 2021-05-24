using ByteBank.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank {
    class Bank {
        private Clients _titular = new Clients();
        private Random rnd = new Random();
        private double _saldo;
        public double Saldo {
            get {
                return _saldo;
            }
        }
        public int Agencia { get; }
        public int ContaCorrente { get; }
        public int ContadorOperacoesNaoPermitidas { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public Bank(string n, string cpf) {
            _titular.Nome = n;
            _titular.Cpf = cpf;
            Agencia = rnd.Next(001, 999);
            ContaCorrente = rnd.Next(100001, 999999);
            _saldo = 50;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }
        public Bank(string n, string cpf, string p) {
            _titular.Nome = n;
            _titular.Cpf = cpf;
            _titular.Profissao = p;
            Agencia = rnd.Next(001, 100);
            ContaCorrente = rnd.Next(100001, 999999);
            _saldo = 50;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        public Bank(string n, string cpf, string p, int agencia, int cc) {
            _titular.Nome = n;
            _titular.Cpf = cpf;
            _titular.Profissao = p;
            Agencia = agencia;
            ContaCorrente = cc;
            if (Agencia <= 0) {
                throw new ArgumentException("Ocorreu um erro no argumento 'agência'.", nameof(agencia));
            }
            if (ContaCorrente <= 0) {
                throw new ArgumentException("Ocorreu um erro no argumento 'conta corrente'", nameof(cc));
            }
            _saldo = 50;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        //
        public static int TotalDeContasCriadas { get; set; }

        public static int TaxaOperacao { get; private set; }
        public String Titular() {
            return this._titular.ToString();
        }
        public String Nome() {
            return this._titular.Nome;
        }
        //


        public void Sacar(double valor) {
            if (valor < 0) {
                ContadorOperacoesNaoPermitidas++;
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }
            if (_saldo < valor) {
                ContadorOperacoesNaoPermitidas++;
                throw new SaldoInsuficienteException(Saldo, valor);
            } else {
                _saldo -= valor;
            }
        }
        public void Transferencia(double valor, Bank destino) {
            if (valor < 0) {
                ContadorOperacoesNaoPermitidas++;
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }
            try {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex) {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Não foi possível realizar esta operação", ex);
            }
            destino.Depositar(valor);
        }
        public void Depositar(double valor) {
            _saldo += valor;
        }
    }
}



