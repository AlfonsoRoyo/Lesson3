using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Class
{   //nueva clase cVirus 
    class cVirus
    {

        //Declaracion de variables

        public string tipus;
        private int Peligrosidad;
        private int taxaCuracion;
        private int numero_infectats;
      
        //Metode constructor  this. hace referencia a las variables de esta clase ,inicializacion variables
        public cVirus()
        {
            this.tipus = "corona";
            this.taxaCuracion = 2;
            this.numero_infectats = 0;
            this.Peligrosidad = 0;
        }
        //se crea un Metodo publico  , se realizan operaciones con las variables de esta clase
         public void contagiar()
        {
            this.numero_infectats++ ;
            this.Peligrosidad = numero_infectats / 10;

            //se crea un Metodo publico  , se muestran en consola las operaciones
        }
        public void informeStatvirus()
        {
            Console.Write("\n Tipus:" + this.tipus);
            Console.Write("\n Numero infectat:" + this.numero_infectats);
            Console.Write("\n perillositat:" + this.Peligrosidad);
        }


    }
}
