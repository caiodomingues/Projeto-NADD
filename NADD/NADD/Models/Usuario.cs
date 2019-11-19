using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Usuario
    {

        private int idUsuario;

        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }

        public Usuario(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario)
        {
            this.UsuarioId = idUsuario;
            this.NomeUsuario = nomeUsuario;
            this.EmailUsuario = emailUsuario;
            this.SenhaUsuario = senhaUsuario;
        }
        public Usuario()
        {

        }

        public Usuario(int idUsuario, string nomeUsuario)
        {
            this.idUsuario = idUsuario;
            this.NomeUsuario = nomeUsuario;
        }
        public virtual void cadastrarArea()
        {
        }

    }
}
