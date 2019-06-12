using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD {
    class Area {
        private string nomeDaArea;

        public Area (string nomeDaArea) {
            this.NomeDaArea = nomeDaArea;
        }

        public string NomeDaArea { get => nomeDaArea; set => nomeDaArea = value; }
    }
}