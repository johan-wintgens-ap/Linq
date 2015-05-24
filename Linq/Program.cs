using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            //Alle schepen die bewapend zijn
            //var bewapendeschepen = from bewapend in schepen
            //                       where bewapend.Bewapend == true
            //                       select bewapend;

            //foreach (var bewapend in bewapendeschepen)
            //{
            //    Console.WriteLine(bewapend.Naam);
            //}

            //oefening 2
            //Alle schepen die trager dan 3 snelheid hebben en niet bewapend zijn
            //var traagonbewapend = from slowUA in schepen
            //                      where slowUA.Snelheid < 3
            //                      where slowUA.Bewapend == false
            //                      select slowUA;

            //foreach (var slowUA in traagonbewapend)
            //{
            //    Console.WriteLine(slowUA.Naam);
            //}

            //oefening 3
            //Groepeer de schepen op hun snelheid
            //var speedrank = from SR in schepen
            //                orderby SR.Snelheid
            //                select SR;
            //foreach (var ruimteschip in speedrank)
            //{
            //    Console.WriteLine(ruimteschip.Naam);
            //}

            //oefening 4
            //Tel het aantal schepen wiens snelheid gelijk is aan 1
            //var countspeed = from FS in schepen
            //                 where FS.Snelheid == 1
            //                 select FS;
            //foreach (var ruimteschip in countspeed)
            //{
            //    Console.WriteLine(ruimteschip.Naam);
            //}

            //oefening 5
            //Toon het eerst schip wiens capaciteit 3 is
            //var fixedcap = from FC in schepen
            //    where FC.Capaciteit == 3
            //    select FC;
            //foreach (var FC in fixedcap)
            //{
            //    Console.WriteLine(FC.Naam);
            //}

            //oefening 6
            //Order de schepen op capaciteit
            //var orderedships = from os in schepen
            //    orderby os.Capaciteit
            //    select os;
            //foreach (var os in orderedships)
            //{
            //    Console.WriteLine(os.Naam);
            //}

            //oefening 7
            //Order de schepen op snelheid en toon het laatste schip
            //var lastShipBySpeed = from ss in schepen
            //    orderby ss.Snelheid
            //    select ss;
            //Console.WriteLine(lastShipBySpeed.Last().Naam);

            //oefening 8
            //Neem de eerste 2 schepen die een capaciteit hebben groter dan 5
            //var biggerCap = from bC in schepen
            //    where bC.Capaciteit > 5
            //    select bC;
            //Console.WriteLine(biggerCap.ElementAt(0).Naam);
            //Console.WriteLine(biggerCap.ElementAt(1).Naam);
        }
    }
}