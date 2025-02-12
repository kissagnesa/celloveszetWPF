using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetWPF.Models
{
    internal class cellovo
    {
        public class Cellovo
        {
            public string Nev { get; private set; }
            public int Loves1 { get; private set; }
            public int Loves2 { get; private set; }
            public int Loves3 { get; private set; }
            public int Loves4 { get; private set; }

            public Cellovo(string sor)
            {
                var adatok = sor.Split(';');
                Nev = adatok[0];
                Loves1 = int.Parse(adatok[1]);
                Loves2 = int.Parse(adatok[2]);
                Loves3 = int.Parse(adatok[3]);
                Loves4 = int.Parse(adatok[4]);
            }

            public Cellovo(string nev, int loves1, int loves2, int loves3, int loves4)
            {
                Nev = nev;
                Loves1 = loves1;
                Loves2 = loves2;
                Loves3 = loves3;
                Loves4 = loves4;
            }

            public int LegnagyobbLoves()
            {
                return Math.Max(Math.Max(Loves1, Loves2), Math.Max(Loves3, Loves4));
            }

            public double Atlag()
            {
                return (Loves1 + Loves2 + Loves3 + Loves4) / 4.0;
            }

            public override string ToString()
            {
                return $"{Nev};{Loves1};{Loves2};{Loves3};{Loves4}";
            }
        }
    }
}
