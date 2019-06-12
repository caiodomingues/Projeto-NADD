using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Avaliacao {
        static int totalAv;
        private List<Questoes> _quetoes = new List<Questoes>();
        private int _qtdQuestoes;
        private double _media;
        private double _totalValue = 0;

        public Avaliacao() {
            totalAv++;
            HoraInicio = DateTime.Now;
            QtdQuestoes = 0;
            TotalValor = 0;
        }
        
        public Avaliacao(string avaliadorNome, string email, DateTime horaDeConclusao,
        int valorProvaExp, int valorDaQuestaoEXP, string refBibliograf, string pQuestMultdisc,
        string eqdistvquest, string ppquestcontext, string observacao, Disciplina disciplina) {
            totalAv++;
            QtdQuestoes = 0;
            Avaliador = avaliadorNome;
            Email = email;
            HoraInicio = DateTime.Now;
            HoraTermino = horaDeConclusao;
            ValorDaProvaExp = valorProvaExp;
            ValorDaQuestaoEXP = valorDaQuestaoEXP;
            RefBibliograf = refBibliograf;
            PQuestMultdisc = pQuestMultdisc;
            Eqdistvquest = eqdistvquest;
            Ppquestcontext = ppquestcontext;
            Observacao = observacao;
            Disciplina = disciplina;
            TotalValor = 0;
        }

        public void NovaQuestao(double valor, string tipo, string observacao) {
            Questoes questao = new Questoes(valor, tipo, observacao);
            VetQuest.Add(questao);
            QtdQuestoes += 1;
            ValorTotalQuestoes();
            MediaDaAvaliacao();
        }

        public double MediaDaAvaliacao() {
            Media = TotalValor / QtdQuestoes;
            return Media;
        }

        public double ValorTotalQuestoes() {
            TotalValor += VetQuest[(QtdQuestoes - 1)].Valor;
            return TotalValor;
        }

        public int QtdQuestoes { get => _qtdQuestoes; set => _qtdQuestoes = value; }
        public double Media { get => _media; set => _media = value; }
        public double TotalValor { get => _totalValue; set => _totalValue = value; }

        public string Avaliador { get; set; }
        public string Email { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public int ValorDaProvaExp { get; set; }
        public int ValorDaQuestaoEXP { get; set; }
        public string RefBibliograf { get; set; }
        public string PQuestMultdisc { get; set; }
        public string Eqdistvquest { get; set; }
        public string Ppquestcontext { get; set; }
        public string Observacao { get; set; }
        internal Disciplina Disciplina { get; set; }
        internal List<Questoes> VetQuest { get => _quetoes; set => _quetoes = value; }
    }
}
