using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Ruota : IComponente
    {
        private double _costo;
        private double _lunghezza;
        private double _altezza;
        private int _pollici_materiale;
        private double _raggio;

        int dim = 0;
        public List<IComponente> componenti;


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
        public double lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value < 0)
                {
                    _lunghezza = 0;
                }
                else
                {
                    _lunghezza = value;
                }
            }
        }

        public double altezza
        {
            get { return _altezza; }
            set
            {
                if (value < 0)
                {
                    _altezza = 0;
                }
                else
                {
                    _altezza = value;
                }
            }
        }

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

        public double raggio
        {
            get { return _raggio; }
            set
            {
                if (value < 0)
                {
                    _raggio = 0;
                }
                else
                {
                    _raggio = value;
                }
            }
        }


        public Ruota()
        {
            componenti = new List<IComponente>();
        }

        public double Costo()
        {
            double temp = 0;
            for (int i = 0; i < dim; i++)
            {
                temp += componenti[i].Costo();
            }

            return temp;
        }

        public string Descrizione()
        {
            string temp = "\nRuota: \n";
            for (int i = 0; i < dim; i++)
            {
                temp += componenti[i].Descrizione() + "\n";
            }

            return temp;
        }

        public void Add(IComponente comp)
        {
            componenti.Add(comp);
            dim++;
        }
        public void Remove(int pos)
        {
            for (int i = pos + 1; i < dim; i++)
            {
                componenti[i - 1] = componenti[i];
            }
            componenti.RemoveAt(dim - 1);
            dim--;
        }

        public IComponente getChild(int pos)
        {
            return componenti[pos];
        }
    }
}