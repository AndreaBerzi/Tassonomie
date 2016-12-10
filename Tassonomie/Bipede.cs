using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Bipede : Animale_Terrestre
    {
        public Bipede(string nome, string tipo, string habitat, int numero):base(nome, tipo, habitat, 2)
        {

        }
        public override string siMuove()
        {
            string d = "tonf,tonf";
            return d;
        }
    }
}
