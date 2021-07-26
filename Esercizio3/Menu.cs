using System;

namespace Esercizio3
{
    internal class Menu
    {
        internal static void Start()
        {
            int scelta;
            do
            {
                Console.WriteLine("Scegli una forma: ");
                Console.WriteLine("1 - Cerchio");
                Console.WriteLine("2 - Rettangolo");
                Console.WriteLine("3 - Triangolo");
                Console.WriteLine("0 - Per uscire");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 3)
                {
                    Console.WriteLine("Errore. Inserisci un numero valido. Riprova: ");
                }
                switch (scelta)
                {
                    case 1:
                        CreaCerchio();
                        break;
                    case 2:
                        CreaRettangolo();
                        break;
                    case 3:
                        CreaTriangolo();
                        break;

                }

            } while (scelta != 0);
                        
        }

        private static void CreaTriangolo()
        {
            throw new NotImplementedException();
        }

        private static void CreaRettangolo()
        {
            throw new NotImplementedException();
        }

        private static void CreaCerchio()
        {
            throw new NotImplementedException();
        }
    }
}