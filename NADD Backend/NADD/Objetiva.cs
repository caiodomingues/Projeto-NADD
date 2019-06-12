using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    public class Objetiva : IQuestao {
        private string observacao;
        private double valor;
        private string tipo;

        public override void VerificaClareza() {
            Console.WriteLine("VerificaClareza");
        }
        public override void VerificaPontuacao() {
            Console.WriteLine("VerificaPontuacao");
        }
        
        public Objetiva(double valor, string tipo, string observacao)  {
            this.observacao = observacao;
            this.valor = valor;
            this.tipo = tipo;
        }

    }
}
