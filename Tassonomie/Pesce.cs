using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Pesce : Animale_acquatico
    {
        public Pesce(string nome, string tipo, string habitat, int numero):base(nome, tipo, habitat, numero)
        {

        }
    }
}
