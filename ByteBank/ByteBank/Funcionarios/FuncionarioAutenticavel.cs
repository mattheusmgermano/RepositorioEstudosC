﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel {
        public FuncionarioAutenticavel(string nome, string cpf, double salario) : base (nome, cpf, salario) {
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
