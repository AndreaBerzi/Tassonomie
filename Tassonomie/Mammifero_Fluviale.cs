using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Mammifero_Fluviale:Animale_Terrestre
    {
        public Mammifero_Fluviale(string nome, string specie, string habitat, int zampe, string manto) : base(nome, "Mammifero_Fluviale", habitat, zampe, manto)
        {

        }
    }
}
