using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class Spiel
    {
        public string Name;
        public DateTime Datum;
        private static List<Spiel> spiele = new List<Spiel>();

        public Spiel(string name, DateTime datum)
        {
            this.Name = name;
            this.Datum = datum;
            spiele.Add(this);
        }

        public static void GibListeAus()
        {
            foreach (Spiel s in spiele)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Datum);
            }
        }


    }
}
