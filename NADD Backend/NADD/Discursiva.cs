using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    public class Discursiva : IQuestao {
        private string observacao;
        private double valor;
        private string tipo;

        public override void VerificaClareza() {
            Console.WriteLine("Chegou no VerificaClareza");
        }
        public override void VerificaPontuacao() {
            Console.WriteLine("Chegou no VerificaPontuacao");
        }
        public Discursiva(string observacao, double valor, string tipo) {
            this.observacao = observacao;
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}
