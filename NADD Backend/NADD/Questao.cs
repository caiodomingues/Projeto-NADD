using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Questao {
        private Avaliacao avaliacao;
        private string observacao;
        private string resultado;

        internal Avaliacao Avaliacao { get => avaliacao; set => avaliacao = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public Questao(Avaliacao avaliacao, string observacao, string resultado) {
            this.Avaliacao = avaliacao;
            this.Observacao = observacao;
            this.Resultado = resultado;
        }
    }
}
