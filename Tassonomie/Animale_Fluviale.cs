using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_Fluviale : Pesce
    {
        public Animale_Fluviale(string nome, string tipo, string habitat, int numero):base(nome, tipo, "fiume", numero)
        {

        }
        public override string siMuove()
        {
            string b = "splash, splash";
            return b;
        }
    }
}
