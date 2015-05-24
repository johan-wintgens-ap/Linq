using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Ruimteschip[] schepen = new Ruimteschip[]
                {
                    new Ruimteschip() {Naam = "SS Enterprise", Bewapend = true, Capaciteit = 5000, Snelheid = 4},
                    new Ruimteschip() {Naam = "Death Star", Bewapend = true, Capaciteit = 50000, Snelheid = 0},
                    new Ruimteschip() {Naam = "Voyager", Bewapend = false, Capaciteit = 3, Snelheid = 1},
                    new Ruimteschip() {Naam = "Norg Cube", Bewapend = true, Capaciteit = 150000, Snelheid = 2},
                    new Ruimteschip() {Naam = "Death Star", Bewapend = true, Capaciteit = 50000, Snelheid = 0},
                    new Ruimteschip() {Naam = "TieFighter", Bewapend = true, Capaciteit = 1, Snelheid = 2},
                    new Ruimteschip() {Naam = "Imperial Shuttle", Bewapend = false, Capaciteit = 3, Snelheid = 1},
                };

            //oefening 1
            /*var bewapendeschepen = from bewapend in schepen
                                   where bewapend.Bewapend == true
                                   select bewapend;

            foreach (var bewapend in bewapendeschepen)
            {
                Console.WriteLine(bewapend.Naam);
            }*/

            //oefening 2
            /*var traagonbewapend = from slowUA in schepen
                                  where slowUA.Snelheid < 3
                                  where slowUA.Bewapend == false
                                  select slowUA;

            foreach (var slowUA in traagonbewapend)
            {
                Console.WriteLine(slowUA.Naam);
            }*/

            //oefening 3
            /*var speedrank = from SR in schepen
                            orderby SR.Snelheid
                            select SR;
            foreach (var ruimteschip in speedrank)
            {
                Console.WriteLine(ruimteschip.Naam);
            }*/

            //oefening 4
            var countspeed = from FS in schepen
                             where FS.Snelheid == 1
                             select FS;
            foreach (var ruimteschip in countspeed)
            {
                Console.WriteLine(ruimteschip.Naam);
            }
        }
    }
}