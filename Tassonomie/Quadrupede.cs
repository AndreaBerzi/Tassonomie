using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Quadrupede : Animale_Terrestre
    {
        public Quadrupede(string nome, string tipo, string habitat, int numero) : base(nome, tipo, habitat, 4)
        {

        }
        public override string siMuove()
        {
            string a = "clop,cloppette";
            return a;
        }
    }
}
