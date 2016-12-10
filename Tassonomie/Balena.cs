using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Balena:Mammifero_Marino
    {
        public Balena() : base("Balena", "Mammifero_Marino", "Mare", 0, "Pelle")
        {

        }
        public override string siMuove()
        {
            return "Nuoto";
        }
    }
}
