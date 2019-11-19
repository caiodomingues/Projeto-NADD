using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        [Display(Name="Nome da Area")]
        public string NomeArea { get; set; }
        [Display(Name = "Data de Criação")]
        public DateTime DtCriacao { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
        public ICollection<Curso> Curso{ get; set; }    
    }
}
