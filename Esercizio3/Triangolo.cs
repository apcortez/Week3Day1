using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    class Triangolo : FormeGeometriche, IFormeGeometriche
    {

        public double Raggio { get; set; }
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public Triangolo(double Base, double Altezza)
        {
            Nome = "Triangolo";
            this.Base = Base;
            this.Altezza = Altezza;
        }
        public double CalcolaLato()
        {
            return Math.Sqrt((Math.Exp(Altezza) + Math.Exp(Base / 2)));
        }
        public override double CalcolaArea()
        {
            double area = Base * Altezza/2;
            return area;
        }

        public override double CalcolaPerimetro()
        {
            double perimetro = Base + CalcolaLato()*2;
            return perimetro;
        }

        public override void PrintForma()
        {
            Console.WriteLine($"***FORMA {Nome.ToUpper()}***");
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Altezza: " + Altezza);
            Console.WriteLine("Lato: " + CalcolaLato());
            Console.WriteLine("Area: " + CalcolaArea());
            Console.WriteLine("Perimetro: " + CalcolaPerimetro());
        }

        public void SaveToFile(string path)
        {
            using (StreamWriter sw1 = new StreamWriter(path))
            {
                sw1.WriteLine($"***FORMA {Nome.ToUpper()}***");
                sw1.WriteLine("Base: " + Base);
                sw1.WriteLine("Altezza: " + Altezza);
                sw1.WriteLine("Lato: " + CalcolaLato());
                sw1.WriteLine("Area: " + CalcolaArea());
                sw1.WriteLine("Perimetro: " + CalcolaPerimetro());
            }
        }

        public void LoadFromFile(string path)
        {
            using (StreamReader sw1 = new StreamReader(path))
            {
                string contenuto = sw1.ReadToEnd();
            }
        }
    }
   
}
