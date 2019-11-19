using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Avaliacao
    {
        [Key]
        public int AvaliacaoId { get; set; }
        [Display(Name = "Data de Aplicacao")]
        public DateTime DtAplicacao { get; set; }
        [Display(Name = "Data de Criação")]
        public DateTime DtCriacao { get; set; }
        [Display(Name = "Quantidade de Questões")]
        public int QtyQuestoes { get; set; }
        [Display(Name = "Valor das Questões Explicitos?")]
        public string ValorQuestExp { get; set; }
        [Display(Name = "Valor da Prova Explicito?")]
        public string ValorProvaExp { get; set; }
        [Display(Name = "Possui Referencias Bibliográficas?")]
        public string RefBibliograficas { get; set; }
        [Display(Name = "Equilibrio e Diversatilidade entre as Questoes?")]
        public string Eqdistvquest { get; set; }
        [Display(Name = "Possui Questões de Multiplas escolhas?")]
        public string PQuestMultdisc { get; set; }
        [Display(Name = "Possui Questões Contextualizadas?")]
        public string Ppquestcontext { get; set; }
        [Display(Name = "Observação sobre a Prova")]
        public string Observacao { get; set; }
        [Display(Name = "Periodo da Turma")]
        public string Periodo { get; set; }

        //FKs
        [Display(Name = "Disciplina")]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplinas { get; set; }

        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Questoes> Questoes { get; set; }
        //Metodos
        internal List<Questoes> VetQuest { get; set; }
        public void NovaQuestao(double valor, string tipo, string observacao)
        {
            Questoes questao = new Questoes();
            questao.Valor = valor;
            questao.Tipo = tipo;
            questao.Observacao = observacao;

            VetQuest.Add(questao);
            QtyQuestoes += 1;
            ValorTotal();
            MediaAvaliacao();
        }
        static int TotAvaliacao;
        public double TotValor { get; set; }

        public double ValorTotal()
        {
            TotValor += VetQuest[(QtyQuestoes - 1)].Valor;

            return TotValor;
        }
        public double Media { get; set; }
        public double MediaAvaliacao()
        {
            Media = TotValor / QtyQuestoes;

            return Media;
        }
        public Avaliacao()
        {

        }

    }
}