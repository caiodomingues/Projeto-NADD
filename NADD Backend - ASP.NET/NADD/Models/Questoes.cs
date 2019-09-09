using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Questoes
    {
        public int QuestoesId { get; set; }

        [Display(Name ="Valor")]
        public double Valor { get; set; }

        [Display(Name = "Tipo de Questão")]
        public string Tipo { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        public int AvaliacaoId { get; set; }
        [Display(Name = "Email do Avaliador")]
        public Avaliacao Avaliacao { get; set; }


       public Questoes(double valor, string tipo, string observacao)
        {
            Valor = valor;
            Tipo = tipo;
            Observacao = observacao;
        }

        public Questoes()
        {

        }
    }
}
