using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank {
    class SistemaInterno {

        public bool Logar(FuncionarioAutenticavel funcionario, string senha) {

            bool _userAutenticado = funcionario.Autenticar(senha);
            if (_userAutenticado) {
                Console.WriteLine("Bem-vindo ao sistema.");
                return true;
            } else {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
        public bool Logar(ParceiroComercial parceiro, string senha) {

            bool _userAutenticado = parceiro.Autenticar(senha);
            if (_userAutenticado) {
                Console.WriteLine("Bem-vindo ao sistema.");
                return true;
            } else {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
