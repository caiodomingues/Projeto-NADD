using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    public class Reitoria : Usuario {
        public Reitoria(string nomeDoUsuario, string emailDoUsuario, string senhaDoUsuario) 
            : base(nomeDoUsuario, emailDoUsuario, senhaDoUsuario) {}

        public override void cadastrarArea() {
            Console.WriteLine("A Área foi Cadastrada com Sucesso!");
        }
    }
}

