using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Menu
    {// Le carte di pagamento sono lunghe 16 cifre.
     // Le prime 6 cifre rappresentano un numero di identificazione univoco per la banca che ha emesso la carta.
        internal static void Start()
        {   long numeroCarta;
            int[] matrixCarta;
            int numeriDispari;
            int sommaCartaDecriptata;
            Console.WriteLine("Inserisci le 16 cifre della carta da verificare: ");
            while (!long.TryParse(Console.ReadLine(), out numeroCarta) || numeroCarta.ToString().Length != 16)
            {
                Console.WriteLine("Errore. Inserisci un numero di carta valido. Riprova: ");

            }

            //Inserisco il numero di carta in una matrice per gestire la verifica
            matrixCarta = CardManager.InsertIntoMatrix(numeroCarta); //TODO: Da rivedere insertMatrix

            //CardManager.PrintCard(numeroCarta);
            //Ricerca prime 6 cifre = identificazione BANCA
            //Ricerca 7-8 cifra = tipo di carta
            //Ricerca 9-15 cifre = numero di serie carta

            int[] matrixCartaDecriptata = CardManager.DecryptCard(matrixCarta, out numeriDispari, out sommaCartaDecriptata);
            
            printCarta(matrixCarta);

            printCarta(matrixCartaDecriptata);

            Console.WriteLine($"{sommaCartaDecriptata} + {numeriDispari} = {sommaCartaDecriptata + numeriDispari}");
            if ((sommaCartaDecriptata + numeriDispari) % 10 == 0)
                {
                    Console.WriteLine("Numero della carta valido.");
                }
            else {
                Console.WriteLine("Numero di carta non valido.");
                 }


            
        }

        private static void printCarta(int[] matrix)
        {
          foreach(var numero in matrix)
            {
                Console.Write(numero + "\t");
            }

            Console.WriteLine("\n");
        }
    }
}
