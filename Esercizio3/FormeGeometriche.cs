using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{   
    abstract class FormeGeometriche
    {
        public string Nome { get; set; }

        public abstract double CalcolaPerimetro();
        public abstract double CalcolaArea();
        public abstract void PrintForma();

        public FormeGeometriche()
        {

        }

        public FormeGeometriche(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
