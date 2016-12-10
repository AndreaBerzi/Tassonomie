using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_Marino : Pesce
    {
        public Animale_Marino(string nome, string tipo, string habitat, int numero):base(nome, tipo, "mare", numero)
        { }
        public override string siMuove()
        {
            string c = "flush,flush";
            return c;
        }
    }
}
