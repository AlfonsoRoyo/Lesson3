using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Class
{
    class cPrincipal
    {
        static void Main(string[] args)
        {
            //contructor de una nueva clase

            cVirus covid19 = new cVirus();


            //llamado a los metodos publicos de la clase cVirus en la nueva clase contruida covid19 (veo que no haria falta)

            //covid19.contagiar();
            //covid19.informeStatvirus();


            for (int i = 0; i < 130; i++) // integracion de la i hasta 100 , cada vez 1
            {
                covid19.contagiar();
                covid19.informeStatvirus();

            }
            //covid19.informeStatvirus();
            Console.ReadLine();
            //................................................................nueva prueba
            // inicializa la clase , constructor
            cVirus GripeA = new cVirus();

            for (int i = 0; i < 100; i++) 
            {
             GripeA.tipus ("GripeA");
             GripeA.contagiar();
             GripeA.informeStatvirus();
            }
            Console.ReadLine();

                
                
         }

    }
}
