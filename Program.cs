using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Wieviele Spiele möchtest du einräumen?");
            int eingabe = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= eingabe; i++)
            {
                Console.WriteLine("Welches Spiel möchtest du deiner Spielesammlung hinzufügen");
                string name = Console.ReadLine();

                Console.WriteLine("Wann ist das Spiel herausgekommen");
                DateTime dt = Convert.ToDateTime(Console.ReadLine());

                Spiel s = new Spiel(name, dt);
                
            }

            Spiel.GibListeAus();
            
            Console.ReadLine();
        }
    }
}
