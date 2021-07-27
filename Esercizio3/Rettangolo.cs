using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    class Rettangolo : FormeGeometriche, IFormeGeometriche
    {

        public double Raggio { get; set; }
    
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

        public void SaveToFile(string path)
        {
            using(StreamWriter sw1 = new StreamWriter(path))
            {
                sw1.WriteLine($"***FORMA {Nome.ToUpper()}***");
                sw1.WriteLine("Larghezza: " + Larghezza);
                sw1.WriteLine("Altezza: " + Altezza);
                sw1.WriteLine("Area: " + CalcolaArea());
                sw1.WriteLine("Perimetro: " + CalcolaPerimetro());
            }
        }

        public void LoadFromFile(string path)
        {
           using(StreamReader sw1 = new StreamReader(path))
            {
                string contenuto = sw1.ReadToEnd();
            }
        }
    }
}
