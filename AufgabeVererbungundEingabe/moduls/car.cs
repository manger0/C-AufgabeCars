using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeVererbungundEingabe.moduls
{
    class Car
    {
        public string Typ, Hersteller, Name, Farbe;
        public int Baujahr;
        public Car(string Typ, string Hersteller, string Name, string Farbe, int Baujahr)
        {
            this.Typ = Typ;
            this.Hersteller = Hersteller;
            this.Name = Name;
            this.Farbe = Farbe;
            this.Baujahr = Baujahr;
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
