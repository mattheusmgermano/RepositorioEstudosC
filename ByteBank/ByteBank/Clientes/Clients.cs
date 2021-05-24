using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Clientes {
    class Clients {

        private string _cpf;
        private string _nome;
        private string _profissao;
        public Endereco _endereco = new Endereco();

        public string Nome {
            get {
                return _nome;
            }
            set {
                _nome = value;
            }
        }
        public string Cpf {
            get {
                return _cpf;
            }
            set {
                _cpf = value;
            }
        }
        public string Profissao {
            get {
                return _profissao;
            }
            set {
                _profissao = value;
            }
        }
        public override string ToString() {
            return "Nome: " +_nome + "\nCPF: " + _cpf + "\nProfissão: " + _profissao;
        }
    }
}
