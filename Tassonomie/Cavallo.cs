using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Cavallo :Animale_Terrestre, Animale_Peloso, Quadrupede
    {
        public Cavallo() : base("cavallo", "quadrupede", "terra", 0,"")
        {

        }
        public void setMantoPeloso()
        {
            manto = "Pelo";
        }
        public void setZampe()
        {
            numeroZampe = 4;
        }
        public override string siMuove()
        {
            return "Galoppo";
        }
    }
}
