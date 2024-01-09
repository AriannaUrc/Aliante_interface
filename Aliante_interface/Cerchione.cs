using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_interface
{
    internal class Cerchione : IComponente
    {
        private int _pollici_materiale;
        private double _costo;

        public int pollici_materiale
        {
            get { return _pollici_materiale; }
            set
            {
                if (value < 0)
                {
                    _pollici_materiale = 0;
                }
                else
                {
                    _pollici_materiale = value;
                }
            }
        }

        public double costo
        {
            get { return _costo; }
            set
            {
                if (value < 0)
                {
                    _costo = 0;
                }
                else
                {
                    _costo = value;
                }
            }
        } 

        public Cerchione(int pollici, double prezzo)
        {
            pollici_materiale= pollici;
            costo = prezzo;
        }

        public string Descrizione()
        {
            return "\nCerchione\n-pollici materiale: " + _pollici_materiale + "\n-Costo: " + costo;
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
