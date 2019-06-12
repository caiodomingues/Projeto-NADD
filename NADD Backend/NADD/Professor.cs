using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Professor {
        private string nomeDoProfessor;
        private string cpfDoProfessor;
        private string telefoneDoProfessor;
        private string emailDoProfessor;

        public string NomeDoProfessor { get => nomeDoProfessor; set => nomeDoProfessor = value; }
        public string EmailDoProfessor { get => emailDoProfessor; set => emailDoProfessor = value; }
        public string TelefoneDoProfessor { get => telefoneDoProfessor; set => telefoneDoProfessor = value; }
        public string CpfDoProfessor { get => cpfDoProfessor; set => cpfDoProfessor = value; }

        public Professor(string nomeDoProfessor, string cpfDoProfessor, string telefoneDoProfessor, string emailDoProfessor) {
            this.NomeDoProfessor = nomeDoProfessor;
            this.CpfDoProfessor = cpfDoProfessor;
            this.TelefoneDoProfessor = telefoneDoProfessor;
            this.EmailDoProfessor = emailDoProfessor;
        }
    }
}
