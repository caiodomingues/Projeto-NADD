using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Disciplina{
        private string nomeDisciplina;
        private Curso curso;

        public Disciplina(string nomeDisciplina, Curso curso) {
            this.NomeDaDisciplina = nomeDisciplina;
            this.Curso = curso;
        }

        public string NomeDaDisciplina { get => nomeDisciplina; set => nomeDisciplina = value; }
        internal Curso Curso { get => curso; set => curso = value; }
    }
}
