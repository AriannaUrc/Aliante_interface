using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Ruota : IComponente
    {

        int dim = 0;
        public List<IComponente> componenti;


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