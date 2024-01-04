using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Aliante : IComponente
    {
        int dim = 0;
        public IComponente[] componenti = new IComponente[100];

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
            componenti[dim] = comp;
            dim++;
        }
        public void Remove(int pos)
        {
            for (int i = pos+1; i < dim; i++) 
            {
                componenti[i-1] = componenti[i];
            }
            dim--;
        }

        public IComponente getChild(int pos)
        {
            return componenti[pos];
        }
    }
}