using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_04_04
{
    class Not_eating_Molecula : Molecula
    {
       

        public Not_eating_Molecula(string name, double weight) : base(name, weight,"No")
        {
        }

        public void Print()
        {
            Console.WriteLine("Eating plankton!");
        }
    }
}
