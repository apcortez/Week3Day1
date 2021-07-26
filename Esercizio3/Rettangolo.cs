using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    class Rettangolo : FormeGeometriche
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; }

        public Rettangolo(double Larghezza, double Altezza) 
        {
            Nome = "Rettangolo";
            this.Larghezza = Larghezza;
            this.Altezza = Altezza;
        }


        public override double CalcolaArea()
        {
            double area = Larghezza * Altezza;
            return area;
        }

        public override double CalcolaPerimetro()
        {
            double perimetro = Larghezza * 2 + Altezza * 2;
            return perimetro;
        }

        public override void PrintForma()
        {
            Console.WriteLine($"***FORMA {Nome.ToUpper()}***");
            Console.WriteLine("Larghezza: " + Larghezza);
            Console.WriteLine("Altezza: " + Altezza);
            Console.WriteLine("Area: " + CalcolaArea());
            Console.WriteLine("Perimetro: " + CalcolaPerimetro());
        }
    }
}
