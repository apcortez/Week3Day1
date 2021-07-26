using System;

namespace Esercizio3
{   //Scrivere un programma per rappresentare le forme geometriche:

    //Tutte le classi avranno una proprietà Nome(stringa),
    //un metodo per il calcolo de perimetro
    //un metodo per il calcolo dell’area
    //un metodo che disegni la forma -> stampare nella console i dettagli delle proprietà e dell’Area



    //Realizzare le classi che rappresentano:
    //Un cerchio che avrà anche le coordinate del centro e il raggio
    //Un rettangolo che avrà anche larghezza e altezza
    //Un triangolo che avrà base e altezza



    //Tutte le classi dovranno implementare la propria versione del metodo di calcolo dell’area, il perimetro e di disegno



    //Aggiungere un'interfaccia che permetta di salvare e leggere i risultati da un file
    //I metodi riceveranno in ingresso il nome del file



    //Creare una istanza di ogni classe nel metodo Main e visualizzare il risultato dell’esecuzione dei metodi.
    class Program
    {
        static void Main(string[] args)
        {
            Centro c = new Centro { X = 5, Y = 7 };
            FormeGeometriche f1 = new Cerchio(10, c);
            FormeGeometriche f2 = new Rettangolo(10, 5);
            FormeGeometriche f3 = new Triangolo(10, 5);


            f1.PrintForma();
            Console.WriteLine("\n");
            f2.PrintForma();
            Console.WriteLine("\n");
            f3.PrintForma();
        }
    }
}
