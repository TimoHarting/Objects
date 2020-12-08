using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Bank
    {
        public static void Bankeinrichtung()
        {
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Bitte gebe die Kontodaten der Kontobesitzer an!");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Kontostand: ");
                double kontostand = Convert.ToDouble(Console.ReadLine());

                Konto konto = new Konto(name, kontostand, i);
            }
        }
    }
}
