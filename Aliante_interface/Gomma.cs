﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_interface
{
    class Gomma : IComponente
    {
		private double _costo;
		private double _lunghezza;
		private double _altezza;
		private double _raggio;


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

		public Gomma(double lung, double alte, double ragg, double prezzo)
		{
			lunghezza = lung;
			altezza = alte;
			raggio = ragg;
			costo = prezzo;
		}

		public string Descrizione()
        {
            return "\nGomma\n- lunghezza: " + lunghezza + "\n - altezza: " + altezza + "\n - raggio: " + raggio + "\n - costo: " + costo;

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
