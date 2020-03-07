using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_Herencia
{
    class cAnimal  //Clase Base de donde heredaremos posteriormente
    {

        //Atributos  del Animal Declaracion de Variables
        string mamifer;
        public string nom;  // para clase base si no se especifica "public" es variable privada
        protected string raza; // "protected" para clase base y derivadas (animal y gos)
        int longevidad;
        public bool perillositat;
        string alimentacio;
        public double peso; //libras , Declaracion de variables para crear una propiedad

        //Declaracion de una propiedad

        public double Peso // propiedad para retornar kilos
        {
            get { return peso / 2.20462; }  //kg

            set { peso = value * 2.20462; Console.WriteLine(Peso); }
        }

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
