using AufgabeVererbungundEingabe.moduls;
using System;
using System.Collections.Generic;

namespace AufgabeVererbungundEingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool KeepGoing = true;
            List<Sportcar> Sportcars = new List<Sportcar>();
            List<Car> Cars = new List<Car>();
            do
            {
                Console.WriteLine("(1) für Autos Anzeigen oder (2) für Auto kreieren");
                string Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    PrintCars(Sportcars, Cars);
                }
                else if (Choice == "2")
                {
                    Create(Sportcars, Cars);
                }
                else
                {
                    Console.WriteLine("ungültige eingabe");
                    KeepGoing = false;
                }
            } while (KeepGoing);
        }

        public static void PrintCars(List<Sportcar> Sportcars, List<Car> Cars)
        {
            Console.WriteLine("Sportautos:\n");
            foreach (Sportcar i in Sportcars)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Autos:\n");
            foreach (Car y in Cars)
            {
                Console.WriteLine(y.ToString());
            }
        }

        public static void Create(List<Sportcar> Sportcars, List<Car> Cars )
        {
            Console.WriteLine("Welchen Typ von Auto wählst du?\n");
            Console.WriteLine("(1) Sportauto");
            Console.WriteLine("(2) Normales Auto");
            string Choice = Console.ReadLine();

            if (Choice == "2")
            {
                Cars.Add(CreateCar());
            }
            else if (Choice == "1")
            {
                Sportcars.Add(CreateSportCar());
            }
            else
            {
                Console.WriteLine("ungültige Eingabe");
            }
        }

        public static Car CreateCar()
        {
            Console.WriteLine("Hersteller eingeben:");
            string Hersteller = Console.ReadLine();
            Console.WriteLine("Typ eingeben:");
            string Typ = Console.ReadLine();
            Console.WriteLine("Name eingeben:");
            string Name = Console.ReadLine();
            Console.WriteLine("Farbe eingeben:");
            string Farbe = Console.ReadLine();
            Console.WriteLine("Baujahr eingeben:");
            int Baujahr = int.Parse(Console.ReadLine());
            Car Car = new Car(Typ, Hersteller, Name, Farbe, Baujahr);
            return Car;
        }

        public static Sportcar CreateSportCar()
        {
            Console.WriteLine("Hersteller eingeben:");
            string Hersteller = Console.ReadLine();
            Console.WriteLine("Typ eingeben:");
            string Typ = Console.ReadLine();
            Console.WriteLine("Name eingeben:");
            string Name = Console.ReadLine();
            Console.WriteLine("Farbe eingeben:");
            string Farbe = Console.ReadLine();
            Console.WriteLine("Baujahr eingeben:");
            int Baujahr = int.Parse(Console.ReadLine());
            Sportcar Sportcar = new Sportcar(Typ, Hersteller, Name, Farbe, Baujahr);
            return Sportcar;
        }
    }
}
