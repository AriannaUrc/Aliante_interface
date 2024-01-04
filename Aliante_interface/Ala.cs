using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Ala : IComponente
    {
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

        public double apertura
        {
            get => default;
            set
            {
                if(value < 0)
                {
                    apertura = 0;
                }
                else
                {
                    apertura = value;
                }
            }
        }

        public string Descrizione()
        {
            return "\nAla\n-lunghezza: " + lunghezza + "\n-apertura: " + apertura;
        }

        public Ala()
        {
            lunghezza = 0;
            apertura = 0;
            costo = 0;
        }

        public Ala(double lunghezza, double apertura, double costo)
        {
            this.lunghezza = lunghezza;
            this.apertura = apertura;
            this.costo = costo;
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

        
    }
}