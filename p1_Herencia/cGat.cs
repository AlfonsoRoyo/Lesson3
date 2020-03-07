using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{
    class cGat : cAnimal // cGat hereda de la clase cAnimal "se escribe asi"
    {
       

        // metodo para inicializar el nombre constructor en la clase derivada
        //  public cGat()
     
        void Miular ()  //Creacion de la funcion de Miular
        {
            if (this.perillositat == false) Console.WriteLine("Domesticat");
            else Console.WriteLine("Salvatge");
        }
    }
}
