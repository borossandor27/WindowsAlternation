using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAlternation
{
    class Madar : Allat
    {
        string tollazat;

        public Madar(string nev, DateTime szuletett, string tollazat) : base(nev,szuletett)
        {
            this.Tollazat = tollazat;
        }

        public string Tollazat { get => tollazat; set => tollazat = value; }
    }
}
