using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Program
    {
        static void Main(string[] args)
        {
            Balena ba = new Balena();
            Cavallo ca = new Tassonomie.Cavallo();
            Corvo co = new Corvo();
            Ippopotamo ip = new Ippopotamo();
            Salmone sa = new Salmone();
            Tonno to = new Tonno();
            Uomo uo = new Uomo();

            {

                ba.Riepilogo();
                Console.WriteLine(ba.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                ca.setMantoPeloso();
                ca.Riepilogo();
                Console.WriteLine(ca.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                co.Riepilogo();
                Console.WriteLine(co.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                ip.Riepilogo();
                Console.WriteLine(ip.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                sa.Riepilogo();
                Console.WriteLine(sa.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                to.Riepilogo();
                Console.WriteLine(to.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                uo.Riepilogo();
                Console.WriteLine(uo.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

            }

            Console.ReadLine();
        }
    }
}
