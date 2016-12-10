using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Uccello : Bipede
    {
        public Uccello(string nome, string tipo, string habitat, int numero) : base(nome, tipo, "terra/aria", numero)
        {

        }
        public override string siMuove()
        {
            string e = "fiu,fiu";
            return e;
        }
    }
}
