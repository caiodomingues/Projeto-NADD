using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NADD.Usuario;

namespace NADD {
    class Program {
        static void Main(string[] args) {
            
            Area Exatas = new Area("Exatas");
            Curso SI = new Curso(Exatas, "Sistemas de Informação");
            Disciplina BancoDeDados = new Disciplina("Banco de Dados II", SI);
            Professor Rosen = new Professor("Rosenclever Lopes Gazoni", "rosenclever@foa.org.br", "99999999", "999.999.999.99");
            UProfessor Debora = new UProfessor("Débora Amorim De Carvalho Paulo","debora@foa.org.br","@debora123");
            UNADD Bruna = new UNADD("Bruna Caziraghi","bruna@foa.org.br","@bruna123");
            Reitoria Carlos = new Reitoria("Carlos José Pacheco", "carlos.pacheco@foa.org.br", "@carlos123");
            Avaliacao firstAVD = new Avaliacao();

            firstAVD.NovaQuestao(10, "Discursiva", "Horrivel!");
            firstAVD.NovaQuestao(3, "Objetiva", "Muito Boa!");
            firstAVD.NovaQuestao(4, "Discursiva", "Excelente!");
            firstAVD.NovaQuestao(5, "Objetiva", "Incrivel!");
            firstAVD.NovaQuestao(8, "Discursiva", "Péssima!");

            Console.WriteLine(Rosen);
            Console.WriteLine("{0} {1}",Exatas.NomeDaArea);
            Console.WriteLine("{0} {1} {2}", SI.NomeDoCurso);
            Console.WriteLine("{0} {1} {2}", BancoDeDados.NomeDaDisciplina, BancoDeDados.Curso);
            Console.WriteLine("{0} {1} {2} {3}", Rosen.EmailDoProfessor, Rosen.TelefoneDoProfessor, Rosen.CpfDoProfessor );

            Console.WriteLine(firstAVD.Media);
            Console.WriteLine(firstAVD.VetQuest);
            Console.Read();
        }
    }
}

