using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Mammifero_Marino:Animale_Marino
    {
        public Mammifero_Marino(string nome, string specie, string habitat, int zampe, string manto) : base(nome, "Mammifero_Marino", "Mare", 0, "Pelle")
        {

        }
    }
}
