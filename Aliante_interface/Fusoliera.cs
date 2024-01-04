using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Fusoliera : IComponente
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

        public string materiale
        {
            get => default;
            set
            {
                materiale = value;
            }
        }

        public double costo
        {
            get => default;
            set
            {
                if(value < 0)
                {
                    costo = 0;
                }
                else
                {
                    costo = value;
                }
            }
        }

        public string Descrizione()
        {
            return "\nFusoliera\n-lunghezza: " + lunghezza + "\n-materiale: "+ materiale + "\n-costo: " + costo;
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