using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Tonno : Pesce
    {
        public Tonno() : base("tonno", "animale acquatico", "mare", 0, "")
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
