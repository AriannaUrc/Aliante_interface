using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Aliante : IComponente
    {
        int dim = 0;
        public IComponente[] componenti;

        public Aliante()
        {
             componenti = new IComponente[100];
        }

        public string Descrizione()
        {
            string temp = "\n";
            for (int i = 0; i < dim; i++)
            {
                temp += componenti[i].Descrizione() + "\n";
            }

            return temp;
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