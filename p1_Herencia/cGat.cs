using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{
    class cGat : cAnimal // Gat hereda de animal
    {
        void Maullar ()
        {
            if (this.perillositat == false) Console.WriteLine("Domesticat");
            else Console.WriteLine("Salvatge");
        }
    }
}
