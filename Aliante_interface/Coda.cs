using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Coda : IComponente
    {
        public double lunghezza
        {
            get => default;
            set
            {
                if (value < 0)
                {
                    lunghezza = 0;
                }
                else
                {
                    lunghezza = value;
                }
            }
        }

        public double costo
        {
            get => default;
            set
            {
                if (value < 0)
                {
                    costo = 0;
                }
                else
                {
                    costo = value;
                }
            }
        }

        public Coda()
        {
            costo = 0;
            lunghezza = 0;
        }

        public Coda(double lunghezza, double costo)
        {
            this.costo = costo;
            this.lunghezza = lunghezza;
        }


        public string Descrizione()
        {
            return "\nCoda\n-lunghezza: " + lunghezza + "\n-costo: " + costo;
        }

        public void Add(IComponente comp)
        {
            throw new System.NotImplementedException();
        }
        public void Remove(int pos)
        {
            throw new System.NotImplementedException();
        }

        public IComponente getChild(int pos)
        {
            throw new System.NotImplementedException();
        }

        public double Costo()
        {
            return costo;
        }
    }
}