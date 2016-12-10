﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Uccello : Animale_Terrestre
    {
        public Uccello(string nome, string tipo, string habitat, int numero, string manto) : base(nome, "Uccello", "terra/aria", numero, manto)
        {

        }
        public override string siMuove()
        {
            return "fiu,fiu";
        }
        public void setMantoPiumoso()
        {
            manto = "Piume";
        }
        public void setZampe()
        {
            numeroZampe = 2;
        }
    }
}
