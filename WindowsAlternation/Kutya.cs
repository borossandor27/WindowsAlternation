using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAlternation
{
    class Kutya : Allat
    {
        string szorzet;

        public string Szorzet { get => szorzet; set => szorzet = value; }

        public Kutya(string nev, DateTime szuletett, string szorzet) : base(nev, szuletett)
        {
            Szorzet = szorzet;
        }
        
    }
}
