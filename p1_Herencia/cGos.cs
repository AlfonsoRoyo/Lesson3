using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{
    class cGos : cAnimal //clase derivada herencia , aqui comenca la fiesta

    {
        public cGos(): this (string n) { }



                              // metodo para inicializar el nombre constructor en la clase derivada


        void Bordar()  //se crea la funcion de bordar
        {
            if (this.raza == "llop") Console.WriteLine("Udolar");
            else Console.WriteLine("Bordad");
        }

    }
}
