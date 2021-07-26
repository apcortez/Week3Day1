using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    class Cerchio : FormeGeometriche
    {

        public double Raggio { get; set; }
        //public int CoordinateX { get; set; }
        //public int CoordinateY { get; set; }
        public Centro Coordinate { get; set; }

        public Cerchio(double Raggio, Centro Coordinate)
        {
            Nome = "Cerchio";
            this.Raggio = Raggio;
            this.Coordinate = Coordinate;
        }


        public override double CalcolaArea()
        {
            double area = Math.Exp(Raggio) * Math.PI;
            return area;
        }


        public override double CalcolaPerimetro()
        {
            double circonferenza = 2 * Raggio * Math.PI;
            return circonferenza;
        }

        public override void PrintForma()
        {
            Console.WriteLine($"***FORMA {Nome.ToUpper()}***");
            Console.WriteLine("Raggio: " + Raggio);
            Console.WriteLine("Circonferenza: " + CalcolaPerimetro());
            Console.WriteLine("Area: " + CalcolaArea());
            Console.WriteLine("Coordinata: X - " + Coordinate.X + " Y - "+Coordinate.Y);
        }
    }
        public struct Centro
        {
            public int X;
            public int Y;


    
    }
    }

