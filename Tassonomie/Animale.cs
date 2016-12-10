using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    public abstract class Animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;
        protected string manto;
        public Animale(string nome, string tipo, string habitat, int numero, string manto)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            this.habitat = habitat;
            numeroZampe = numero;
            this.manto = manto;
        }
        public abstract string siMuove();

        public void Riepilogo()
        {
            Console.WriteLine(nomeAnimale);
            Console.WriteLine(tipoAnimale);
            Console.WriteLine(habitat);
            Console.WriteLine(numeroZampe);
        }
    }
}
