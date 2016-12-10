using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Pinguino : Uccello_marino, Animale_piumoso
    {
        public Pinguino() : base("pinguino", "Uccello_Marino", "terra/acqua", 2, "")
        {

        }
        public void setMantoPiumoso()
        {
            manto = "Piume";
        }
        public override string siMuove()
        {
            return "Nuoto/Cammino";
        }
    }
}
