using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_acquatico : Animale
    {
        public Animale_acquatico(string nome, string tipo, string habitat, int numero):base(nome, "animale acquatico", habitat, 0)
        {

        }
    }
}
