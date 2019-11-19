using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Disciplina 
    {
        public int DisciplinaId { get; set; }

        [Required]
        [Display(Name = "Nome da Disciplina")]
        public string NomeDisciplina { get; set; }
        [Display(Name = "Data de Criação")]
        public DateTime DtCriacao { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public ICollection<Avaliacao> Avaliacao { get; set; }

        public Disciplina()
        {
           
        }
    }
}
