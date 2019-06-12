using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Curso {
        private Area area;
        private string nomeDoCurso;

        public Curso(Area area, string nomeDoCurso) {
            this.Area = area;
            this.NomeDoCurso = nomeDoCurso;
        }

        internal Area Area { get => area; set => area = value; }
        public string NomeDoCurso { get => nomeDoCurso; set => nomeDoCurso = value; }
    }
}
