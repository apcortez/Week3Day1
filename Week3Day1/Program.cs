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
            //Value Type sono strutture ed enum --> Struct && enum
            //Esempi di value type
            //int i;
            //double d;
            //bool isValid;
            DateTime dt;
            Season season;
            DateTime dt1 = new DateTime();
            int primoValore = 100;
            int secondoValore = primoValore;
            Console.WriteLine($"Il valore del mio primoValore è {primoValore}");     //100
            Console.WriteLine($"Il valore del mio secondoValore è {secondoValore}"); //100

            primoValore = 200;
            Console.WriteLine($"Il valore del mio primoValore è {primoValore}");     //200
            Console.WriteLine($"Il valore del mio secondoValore è {secondoValore}"); //100



            //Reference Type = 2 variabili possono far riferimento allo stesso oggetto presente nell'heap
            string s;
            int[] array;
            Person p;

            Person persona1 = new Person();
            persona1.Nome = "Angelica";
            persona1.Eta = 27;
            Person persona2 = persona1;

            Console.WriteLine($"La persona 1 si chiama {persona1.Nome} e ha {persona1.Eta} anni"); //Angelica 27
            Console.WriteLine($"La persona 2 si chiama {persona2.Nome} e ha {persona2.Eta} anni"); //Angelica 27

            persona1.Nome = "Arianna";
            persona1.Eta = 30;

            Console.WriteLine($"La persona 1 si chiama {persona1.Nome} e ha {persona1.Eta} anni"); //Arianna 30
            Console.WriteLine($"La persona 2 si chiama {persona2.Nome} e ha {persona2.Eta} anni"); //Arianna 30
            //Come vediamo dalle stampe cambiando il valore dell'oggetto persona1 cambia anche il valore dell'oggetto persona2
            //perchè puntano allo stesso puntatore (persona2 punta allo stesso puntatore di memoria di persona1), essendo passati per riferimento.
            //modificano la stessa cella heap.

            //Null '?' per value type
            int? n = null;  //-> n = null, senza '?' non si possono inizializzare i type value = null. Per valorizzarli nulli devi mettere '?'
            double? d;
            //bool? isValid;

            //Non posso passare un valore nullable a un value type non nullabile
            //esempio errore:
            //int c = n;
            
            n = 3;
            int c = (int)n; //devi fare il cast forzato ad int prima di passarlo ad un type value

            bool? isValid = null;
            //metodo 1
            var valoreBool = isValid.HasValue ? isValid.Value : false;
            
            //metodo 2
            valoreBool = isValid ?? false; //se ha il valore allora assegna il valore altrimenti false

            //metodo 3 per rappresentare il ternario è 
            //if(isValid != null)
            //{
            //    valoreBool = isValid.Value;
            //}
            //else
            //{
            //    valoreBool = false;
            //}


        }

        enum Season
        {
            Spring, 
            Summer,
            Autumn,
            Winter
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
