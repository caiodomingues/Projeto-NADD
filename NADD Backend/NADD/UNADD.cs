using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    public class UNADD : Usuario {
        public UNADD(string nomeDoUsuario, string emailDoUsuario, string senhaDoUsuario) 
            : base(nomeDoUsuario, emailDoUsuario, senhaDoUsuario) {}
        
        public override void cadastrarArea() {
            Console.WriteLine("A Área foi enviada para Reitor fazer a Avaliação, se ela for aceita, a Área será cadastrada com sucesso!.");
        }
    }
}
