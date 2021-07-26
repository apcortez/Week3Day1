using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class CardManager
    { 
        internal static int[] InsertIntoMatrix(long numeroCarta) //TODO da rivedere insert
        {
            int[] MatrixCarta = new int[16];
            string numCarta = numeroCarta.ToString();

            for(int i =0; i< MatrixCarta.Length; i++)
            {
                MatrixCarta[i] = (int)numCarta[i];
            }

            return MatrixCarta;

        }

        internal static int[] DecryptCard(int[] matrixCarta, out int numeroDispari, out int totale)
        {
            int numeroRaddoppiato;
            numeroDispari = 0;
            totale = 0;
            int[] MatrixCartaDecriptata = new int[matrixCarta.Length];
            for(int i = 0; i<matrixCarta.Length; i++)
            {
                if (i % 2 == 0)
                {
                       numeroRaddoppiato = matrixCarta[i] * 2;
                    if (numeroRaddoppiato > 9)
                    {
                        numeroRaddoppiato = numeroRaddoppiato - 9;
                    }
                    MatrixCartaDecriptata[i] = numeroRaddoppiato;
                    numeroDispari++;
                }
                else
                {
                    MatrixCartaDecriptata[i] = matrixCarta[i];

                }

                totale = totale + MatrixCartaDecriptata[i];
               
            }
            return MatrixCartaDecriptata;

        }

    }
}
