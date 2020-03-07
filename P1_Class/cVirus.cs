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
        private int Perillositat;
        private int taxaCuracion;
        private int numero_infectats;
        private double temperatura; //Kelvin

        public  double Temperatura // propiedad para retornar grados
        {
            get { return temperatura - 273.15; }  //ºC

            set { 
                temperatura = value + 273.15;
                Console.WriteLine(temperatura);
            }
        }
        public int perill    //se crean las propiedades 
        {
            // get; set; 
            
            //Read Only
            // creando propiedades
            //Set
            get {
                if (this.tipus == "gripe")
                {
                return (this.Perillositat / 10);
                }
                else
                {
                  return (this.Perillositat / 100);
                }
               // return this.Perillositat;    
            } 
            //Write
            set {
                Perillositat = value;
            } //Writte
        }

        public int TaxaCuracion { get => taxaCuracion; set => taxaCuracion = value; }//realizado como la parte de arriba
        public int Numero_infectats { get => numero_infectats; set => numero_infectats = value; }



        //Metode constructor  this. hace referencia a las variables de esta clase ,inicializacion variables
        public cVirus() // atributos
        {
            this.tipus = "corona";
            this.TaxaCuracion = 2;
            this.Numero_infectats = 0;
            this.Perillositat = 0;
        }


        public cVirus(string _tipus, int _taxa_curacio, int _num_infectats, int _Perillositat) // atributos
        {
            this.tipus = _tipus;
            this.TaxaCuracion = _taxa_curacio;
            this.Numero_infectats = _num_infectats;
            this.Perillositat = _Perillositat;
        }
        //se crea un Metodo publico  , se realizan operaciones con las variables de esta clase
        public void contagiar()
        {
            if (this.tipus=="corona")

            {
                this.Numero_infectats++;
                this.Perillositat = Numero_infectats / 10;

            }   

            else if (this.tipus=="gripe")
            {

                this.Numero_infectats=+2;
                this.Perillositat = Numero_infectats / 100;
            }

            //se crea un Metodo publico  , se muestran en consola las operaciones
        }


        public void informeStatvirus()
        {
            Console.Write("\n Tipus de Virus:" + this.tipus);
            Console.Write("\n Numero infectat:" + this.Numero_infectats);
            Console.Write("\n perillositat:" + this.Perillositat);
        }


    }
}
