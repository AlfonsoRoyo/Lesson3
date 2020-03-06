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
            cVirus gripeA = new cVirus("gripe" ,3,45,1);
           

            gripeA.Temperatura = 10; //Set
            double p = gripeA.Temperatura; //get
         



            for (int i = 0; i < 130; i++) // integracion de la i hasta 100 , cada vez 1
            {
                covid19.contagiar();
                covid19.informeStatvirus();
                gripeA.contagiar();
                gripeA.informeStatvirus();
            }
            Console.ReadLine();


        }

    }
}
