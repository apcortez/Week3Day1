using System;

namespace Week3Day1
{   
    class Program
    {   
        static void Main(string[] args)
        {
            //IterazioneVsRicorsione();
            ValueVsReferenceType();
        
        }

        private static void ValueVsReferenceType()
        {
            
        }

        private static void IterazioneVsRicorsione()
        {
            //ESEMPIO ESERCIZIO FATTORIALE
            // Dato un numero intero >= 0, cacolarne il fattoriale
            // n! = n * (n-1) * (n-2) * .... 2 * 1
            // n! = 1 * 2 * 3 * ... * n
            // n! = 1 * (1+1) * (1+2) * ... * n

            // n! = n * (n-1)!
            // (n-1)! = (n-1) * (n-1-1)!

            // Ma... 0! = 1

            int numero;
            int fattoriale = 1;
            Console.WriteLine("Inserisci un numero maggiore o uguale a zero: ");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Inserisci un numero valido. Riprova: ");

            }

            //Iterazione
            for (int i = 0; i <= numero; i++)
            {
                fattoriale = fattoriale * i;
            }

            //fattoriale = 1;
            //for(int i = numero; i > 0; i--)
            //{
            //    fattoriale = fattoriale * i;
            //}

            //Ricorsione
            int fattorialeRicorsione = FattorialeRicorsione(numero);
        }

        //Ricorsione Metodo
        public static int FattorialeRicorsione(int numero)
        {
            if(numero ==0)
            {
                return 1;

            }
            else
            {
                return numero * FattorialeRicorsione(numero - 1);
            }
        }
    }
}
