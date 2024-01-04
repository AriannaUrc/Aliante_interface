using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Coda : IComponente
    {
        public double lughezza
        {
            get => default;
            set
            {
            }
        }

        public double costo
        {
            get => default;
            set
            {
            }
        }

        public string Descrizione()
        {
            throw new System.NotImplementedException();
        }

        public double Costo()
        {
            throw new System.NotImplementedException();
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