using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeVererbungundEingabe.moduls
{
    internal class Sportcar : Car
    {
        public Sportcar(string Typ, string Hersteller, string Name, string Farbe, int Baujahr) 
            : base(Typ, Hersteller, Name, Farbe, Baujahr)
        {
        }
        public override string ToString()
        {
            return 
                "\nHersteller: " + Hersteller +
                "\nTyp: " + Typ +
                "\nName: " + Name +
                "\nFarbe: " + Farbe +
                "\nBaujahr: " + Baujahr + "\n";
        }
    }
}
