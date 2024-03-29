﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Questoes
    {
        public int QuestoesId { get; set; }
        [Display(Name = "Numero da Questão")]
        public string NumeroQuestao { get; set; }
        [Display(Name ="Valor da Questão")]
        public double Valor { get; set; }
        [Display(Name = "Tipo de Questão")]
        public string Tipo { get; set; }
        [Display(Name = "Observação da Questão")]
        public string Observacao { get; set; }
        [Display(Name = "Questão Contextualizada?")]
        public string Contextualizada { get; set; }
        [Display(Name = "Questão possui Clareza?")]
        public string Clareza { get; set; }
        [Display(Name = "Questão possui Complexibilidade?")]
        public string Complexibilidade { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Avaliacao")]
        public int AvaliacaoId { get; set; }
        [Display(Name = "Avaliacao")]
        public Avaliacao Avaliacao { get; set; }

        /*public Questoes(double valor, string tipo, string observacao)
        {
            Valor = valor;
            Tipo = tipo;
            Observacao = observacao;
        }*/
        
        public Questoes()
        {

        }
    }
}
