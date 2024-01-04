using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public interface IComponente
    {
        void Add(IComponente comp);
        void Remove(int pos);
        IComponente getChild(int pos);
        double Costo();
        string Descrizione();
    }
}