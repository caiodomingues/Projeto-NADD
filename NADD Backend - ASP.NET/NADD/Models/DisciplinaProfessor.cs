using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class DisciplinaProfessor
    {
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
