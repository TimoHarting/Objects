using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aussteigen = true;

            Bank.Bankeinrichtung();

            while (aussteigen)
            {
                Console.WriteLine("Möchtest du eine Transaktion anlegen?");
                Console.WriteLine("Ja/j             Nein/n");

                var abfragekey = Console.ReadKey().KeyChar;

                switch (abfragekey)
                {
                    case 'j':
                        Console.Clear();
                        Konto.Transaktionen();
                        break;
                    case 'n':
                        aussteigen = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
