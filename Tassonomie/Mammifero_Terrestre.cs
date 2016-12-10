using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Mammifero_Terrestre:Animale_Terrestre
    {
        public Mammifero_Terrestre(string nome, string specie, string habitat, int zampe, string manto) : base(nome, "Mammifero_Terrestre", habitat, zampe, manto)
        {

        }
    }
}
