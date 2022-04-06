using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_04_04
{
    class Eating_Molecula:Molecula
    {
      

        public Eating_Molecula(string name,double weight):base(name,weight,"Yes")
        {
           
        }

        public void Eating(Molecula exampl)
        {
           
                if (exampl.weight > 0.02)
                {
                    exampl.weight -= 0.02;
                    this.weight += 0.02;
                }
           

        }

    }
}
