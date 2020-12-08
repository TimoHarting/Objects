using System;
using System.Collections.Generic;

namespace ConsoleApp27
{
    class Konto
    {
        private string Name;
        private int Nummer;
        private double Kontostand;

        private static List<Konto> Kontenliste = new List<Konto>();

        public Konto(string name, double kontostand, int nummer)
        {
            Name = name;
            Nummer = nummer;
            Kontostand = kontostand;

            Kontenliste.Add(this);
        }

        public static void Transaktionen()
        {
            foreach (var k in Kontenliste)
            {
                Console.WriteLine();
                Console.WriteLine(k.Name + " " + k.Nummer);
            }

            Console.Write("An welches Konto Möchtest du überweisen: ");
            int kontoauswahl = Convert.ToInt16(Console.ReadLine());

            if (kontoauswahl == 1)
            {
                Ueberweisung(kontoauswahl);
            }
            else if (kontoauswahl == 2)
            {
                Ueberweisung(kontoauswahl);
            }
        }

        public static void Ueberweisung(int kontoauswahl)
        {
            Console.WriteLine("Du kannst jetzt an das Konto: " + kontoauswahl + " überweisen");
            Console.Write("Wieviel möchtest du überweisen?: ");
            double betrag = Convert.ToDouble(Console.ReadLine());

            bool geldpruefung = true;

            foreach (var k in Kontenliste)
            {
                if (kontoauswahl != k.Nummer)
                {
                    if (Kontostandspruefung(geldpruefung, k, betrag) == false)
                    {
                        Console.WriteLine("Überweisung nicht möglich!");
                        geldpruefung = false;
                    }
                    else
                    {
                        Console.WriteLine("Überweisung erfolgreich");
                        geldpruefung = true;
                    }
                }
                else if (kontoauswahl == k.Nummer)
                {
                    if (geldpruefung == false)
                    {
                        Console.WriteLine("Überweisung nicht möglich!");
                    }
                    else
                    {
                        Console.WriteLine("Überweisung erfolgreich");
                        k.Kontostand = k.Kontostand + betrag;
                    }
                }

                Console.Write(k.Nummer + " " + k.Name + " ");
                Console.WriteLine(k.Kontostand);
                Console.WriteLine();
            }
        }

        private static bool Kontostandspruefung(bool geldpruefung, Konto k, double betrag)
        {
            if (k.Kontostand < betrag)
            {
                Console.WriteLine("Kontostand zu Niedrig");
                geldpruefung = false;
            }
            else
            {
                k.Kontostand = k.Kontostand - betrag;
                geldpruefung = true;
            }
            return geldpruefung;
        }
    }
}

