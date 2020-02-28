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
            covid19.contagiar();
            covid19.informeStatvirus();
            for(int i=0; i<100; i++)
            {
                covid19.contagiar();
                covid19.informeStatvirus();

            }

            covid19.informeStatvirus();
            Console.ReadLine();
        }

    }
}
