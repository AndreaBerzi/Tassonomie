using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Pesce : Animale_Marino
    {
        public Pesce(string nome, string tipo, string habitat, int numero, string manto):base(nome, "Pesce", "Mare", 0, manto)
        {

        }
    }
}
