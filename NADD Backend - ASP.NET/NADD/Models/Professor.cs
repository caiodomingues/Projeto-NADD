using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }

        [Required]
        [Display(Name ="Nome do(a) Professor(ra)")]
        public string NomeProfessor { get; set; }

        [Required]
        [Display(Name = "Email do(a) Professor(ra)")]
        public string EmailProfessor { get; set; }

        [Required]
        [Display(Name = "Telefone do(a) Professor(ra)")]
        public string TelProfessor { get; set; }

        [Required]
        [Display(Name = "CPF do(a) Professor(ra)")]
        public string CpfProfessor { get; set; }

        public ICollection<DisciplinaProfessor> DisciplinaProfessor { get; set; }

        public Professor()
        {

        }
    }
}
