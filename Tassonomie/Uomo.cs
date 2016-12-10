﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Uomo : Mammifero_Terrestre, Bipede, Animale_Peloso
    {
        public Uomo() : base("Uomo", "Terrestre", "Terra", 0, "")
        {

        }
        public void setMantoPeloso()
        {
            manto = "SemiPeloso";
        }
        public void setZampe()
        {
            numeroZampe = 2;
        }
        public override string siMuove()
        {
            return "Cammino";
        }
    }
}
