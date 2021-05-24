using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Clientes {
    class Endereco {

        public string _logradouro;
        public int _num;
        public string _complemento;
        public string _cidade;
        public string _estado;

        public string Logradouro { 
            get {
                return _logradouro;
            } 
            set {
                _logradouro = value;
            } 
        }
        public int Numero {
            get {
                return _num;
            }
            set {
                _num = value;
            }
        }
        public string Complemento {
            get {
                return _complemento;
            }
            set {
                _complemento = value;
            }
        }
        public string Cidade {
            get {
                return _cidade;
            }
            set {
                _cidade = value;
            }
        }
        public string Estado {
            get {
                return _estado;
            }
            set {
                _estado = value;
            }
        }
        public override string ToString() {
            return _logradouro + " " + _num + " " + _complemento + " " + _cidade + " " + _estado;
        }

    }
}
