using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD{
    public abstract class Usuario {
        private int usuairo;
        private string nomeDoUsuario;
        private string emailDoUsuario;
        private string senhaDoUsuario;

        public string NomeDoUsuario { get => nomeDoUsuario; set => nomeDoUsuario = value; }
        public string EmailDoUsuario { get => emailDoUsuario; set => emailDoUsuario = value; }
        public string SenhaDoUsuario { get => senhaDoUsuario; set => senhaDoUsuario = value; }

        public Usuario(){}
        public Usuario(string nomeDoUsuario){
            this.nomeDoUsuario = nomeDoUsuario;
        }

        public Usuario(string nomeDoUsuario, string emailDoUsuario, string senhaDoUsuario)
        {
            this.NomeDoUsuario = nomeDoUsuario;
            this.EmailDoUsuario = emailDoUsuario;
            this.SenhaDoUsuario = senhaDoUsuario;
        }

        public virtual void cadastrarArea(){}
    }
}
