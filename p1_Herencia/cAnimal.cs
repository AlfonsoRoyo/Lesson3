using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{
    class cAnimal  //clase base
    {

        //atributos  del Animal

        string mamifer;
        public string nom;  // para clase base si no se especifica es variable privada
        protected string raza; // "protected" para clase base y deribadas (animal y gos)
        int longevidad;
        public bool perillositat;
        string alimentacio;

        //funciones , metodes
       // Metode Dormir 

        public cAnimal (string n) { nom = n; } // metodo para inicializar el nombre constructor
        public void Dormir() { }  // metodod publico para clase base y clase derivada
        public void Menjar() { }


        ~cAnimal() // finalizer  si no es posa es crida el destructor garbage colector

        {
            Console.WriteLine ("Muerte!!{0}",nom);



        }
        //

     

    }


}
