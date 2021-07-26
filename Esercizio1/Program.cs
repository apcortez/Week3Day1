using System;

namespace Esercizio1
{
    class Program
    {    // Scrivere una funzione che dato un importo di denaro iniziale,
         // un interesse annuo e un numero di anni permette di calcolare
         // l’importo di denaro accresciuto degli interessi dopo il numero di anni passati

        // Esempio
        // Voglio vincolare 10000 euro per 3 anni con un interesse del 3%

        // Dopo 1 anno : 10000 + (10000 * 3 / 100) = 10000 + 300 = 10300
        // Dopo 2 anni : 10300 + (10300 * 3 / 100) = 10300 + 309 = 10609
        // Dopo 3 anni : 10609 + (10609 * 3 / 100) = 10609 + 318,27 = 10927,27
        static void Main(string[] args)
        { 
            double importo;
            double totaleInvestimento;
            int anni;
            Console.WriteLine("Inserisci un importo di denaro da vincolare: ");
            while(!double.TryParse(Console.ReadLine(), out importo) || importo <= 0)
            {
                Console.WriteLine("Errore. Inserisci un importo valido. Riprova: ");
            }

            Console.WriteLine("Inserisci il numero di anni in cui vuoi vincolare tale importo: ");
            while (!int.TryParse(Console.ReadLine(), out anni) || anni < 0)
            {
                Console.WriteLine("Errore. Inserisci un numero valido. Riprova: ");
            }
            Random random = new Random();
            int tassoInteresse = random.Next(2, 6);
            totaleInvestimento = importo;
            double importoRicorsione = importo;

            for(int i =0; i<anni; i++)
            {
                totaleInvestimento = totaleInvestimento + (totaleInvestimento * tassoInteresse / 100);
                Console.WriteLine($"Dopo {i + 1} anno: {importo} + ({importo} * {tassoInteresse} / 100 ) = {totaleInvestimento}");
                importo = totaleInvestimento;

            }
            Console.WriteLine("\n");
            double totaleInvestimentoRicorsione = CalcolaInvestimentoRicorsione(importoRicorsione, tassoInteresse, anni);
            Console.WriteLine($"L'importo {importoRicorsione} euro da vincolare per {anni} anni con un interesse del {tassoInteresse}% rende {totaleInvestimentoRicorsione} euro.");
        }

        private static double CalcolaInvestimentoRicorsione(double importo, int tassoInteresse, int anni)
        {
            
            if(anni == 0)
            {

                return importo;
            }
            else
            {
                return CalcolaInvestimentoRicorsione(importo + (importo * tassoInteresse / 100), tassoInteresse, --anni);
               
            }
           
        }
    }
}
