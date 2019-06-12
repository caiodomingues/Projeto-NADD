using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Questoes : FabricaDeQuestoes {
        private double _valor;
        private string _observacao;
        private string _tipo;

        public Questoes(double valor, string observacao, string tipo) {
            Valor = valor;
            Observacao = observacao;
            Tipo = tipo;
        }

        public double Valor { get => _valor; set => _valor = value; }
        public string Observacao { get => _observacao; set => _observacao = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }

        public override IQuestao criarQuestao() {
            if (Tipo.Equals("Objetiva"))
                return new Objetiva(Valor, Tipo, Observacao);
            else return new Discursiva(Observacao, Valor, Tipo);
            
        }
    }
}
