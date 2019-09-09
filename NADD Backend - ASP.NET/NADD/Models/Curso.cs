using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [Required]
        [Display(Name = "Nome do Curso")]
        [StringLength(100, ErrorMessage ="Número de Caracteres Invalido!")]
        public string NomeCurso { get; set; }

        [Required]
        public int AreaId { get; set; }
        public Area Area { get; set; }

        public ICollection<Disciplina> Disciplina { get; set; }


        public Curso()
        {

        }


    }
}

