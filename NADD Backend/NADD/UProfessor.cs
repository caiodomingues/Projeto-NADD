using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    public class UProfessor : Usuario {
        public UProfessor(string nomeDoUsuario, string emailDoUsuario, string senhaDoUsuario) 
            : base(nomeDoUsuario, emailDoUsuario, senhaDoUsuario) {}

        public override void cadastrarArea() {
            Console.WriteLine("Erro ao Cadastrar uma Área");
        }

        public string avisoNovaAvaliacao() {
            return "Nenhuma Nova Avaliação";
        }
    }
}
