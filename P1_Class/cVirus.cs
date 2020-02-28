using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Class
{
    class cVirus
    {
        public string tipus;
        private int Peligrosidad;
        private int taxaCuracion;
        private int numero_infectats;
      
        //Metode constructor
        public cVirus()
        {
            this.tipus = "corona";
            this.taxaCuracion = 2;
            this.numero_infectats = 0;
            this.Peligrosidad = 0;



        }

//metodo publico
         public void contagiar()
        {

            this.numero_infectats++;

            this.Peligrosidad = numero_infectats / 10;

        }public void informeStatvirus()
        {

            Console.Write("\n Tipus:" + this.tipus);
            Console.Write("\n Numero infectat:" + this.numero_infectats);
            Console.Write("\n perillositat:" + this.Peligrosidad);
        }


    }
}
