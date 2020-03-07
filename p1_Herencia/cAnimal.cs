using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{
    class cAnimal  //Clase Base de donde heredaremos posteriormente
    {

        //atributos  del Animal

        string mamifer;
        public string nom;  // para clase base si no se especifica "public" es variable privada
        protected string raza; // "protected" para clase base y derivadas (animal y gos)
        int longevidad;
        public bool perillositat;
        string alimentacio;


        // Inizialitzacio  del nombre constructor
        
        public cAnimal (string n) { nom = n; } 

        // Creacion de los Metodos Dormir,Mejar

        public void Dormir() { }  // metodod publico para clase base y clase derivada
        public void Menjar() { }
        

        ~cAnimal() // finalizer  si no es posa es crida el destructor garbage colector

        {
            Console.WriteLine ("Muerte!!{0}",nom);

        }
 
    }


}
