using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAlternation
{
    class Allat
    {
        string nev;
        DateTime szuletett;

        public string Nev
        {
            get => nev; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    new ArgumentException("Nem adott meg nevet!");
                }
                else
                {
                    nev = value;
                }
            }
        }
        public DateTime Szuletett
        {
            get => szuletett; 
            set
            {
                if (DateTime.Compare(DateTime.Now, value) == 1)
                {
                    szuletett = value;
                }
                else
                {
                    throw new ArgumentException("Érvénytelen dátum!");
                }
            }
        }

        public Allat(string nev, DateTime szuletett)
        {
            Nev = nev;
            Szuletett = szuletett;
        }

        public override string ToString()
        {
            return $"{nev} ({szuletett.ToString("yyyy-MM-dd")})";
        }
    }
}
