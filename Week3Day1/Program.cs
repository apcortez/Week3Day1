using System;

namespace Week3Day1
{   // Dato un numero intero >= 0, cacolarne il fattoriale
    // n! = n * (n-1) * (n-2) * .... 2 * 1
    // n! = 1 * 2 * 3 * ... * n
    // n! = 1 * (1+1) * (1+2) * ... * n

    // n! = n * (n-1)!
    // (n-1)! = (n-1) * (n-1-1)!

    // Ma... 0! = 1
    class Program
    {   
        static void Main(string[] args)
        {
            int numero;
            int fattoriale=1;
            Console.WriteLine("Inserisci un numero maggiore o uguale a zero: ");
            while(!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Inserisci un numero valido. Riprova: ");

            }

            //Iterazione
            for(int i = 0; i<=numero; i++)
            {
                fattoriale = fattoriale * i;
            }

            //fattoriale = 1;
            //for(int i = numero; i > 0; i--)
            //{
            //    fattoriale = fattoriale * i;
            //}
        }

        
    }
}
