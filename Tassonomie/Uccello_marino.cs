using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Uccello_marino:Animale_Marino
    {
        public Uccello_marino(string nome, string tipo, string habitat, int numero, string manto):base(nome,"Uccello Marino",habitat, numero, manto)
        {

        }
        public override string siMuove()
        {
            return "Cammina";
        }
        public void setMantoPiumoso()
        {
            manto = "piume";
        }
        public void setZampe()
        {
            numeroZampe = 2;
        }
    }
}
