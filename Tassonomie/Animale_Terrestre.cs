using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_Terrestre : Animale
    {
        public Animale_Terrestre(string nome, string tipo, string habitat, int numero):base(nome, "animale terrestre", habitat, numero)
        {

        }
    }
}
