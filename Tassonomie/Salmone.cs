using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Salmone : Pesce
    {
        public Salmone() : base("salmone","animale acquatico","fiume",0, "")
        {

        }
        public void setMantoSquamoso()
        {
            manto = "Squame";
        }
        public override string siMuove()
        {
            return "Nuoto";
        }
    }
}
