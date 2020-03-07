using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{


   class cGos : cAnimal // cGos hereda de la clase cAnimal "se escribe asi"
   
    {

        // Inizialitzacio  del nombre constructor

        // metodo para inicializar el nombre constructor en la clase derivada
        public cGos(): this (string n) { }
        

        void Bordar()  //Creacion de la funcion de bordar
        {
            if (this.raza == "llop") Console.WriteLine("Udolar");
            else Console.WriteLine("Bordad");
            
        }
        
    }
}
