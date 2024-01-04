using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Ruota : IComponente
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

        public double altezza
        {
            get => default;
            set
            {
                if (value < 0)
                {
                    altezza = 0;
                }
                else
                {
                    altezza = value;
                }
            }
        }

        public int pollici_materiale
        {
            get => default;
            set
            {
                if(value < 0)
                {
                    pollici_materiale = 0;
                }
                else
                {
                    pollici_materiale = value;
                }
            }
        }

        public double raggio
        {
            get => default;
            set
            {
                if(value < 0)
                {
                    raggio = 0;
                }
                else
                {
                    raggio = value;
                }
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
            return "\nFusoliera\n-lunghezza: " + lunghezza + "\n-altezza: " + altezza + "\n-pollici_materiale: " + pollici_materiale + "\n-raggio: " + raggio + "\n-costo: " + costo;
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