using System;

namespace Classwork_04_04
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Molecula one = new Molecula("first", 0.20d,"Yes");
            Molecula two = new Molecula("second", 0.05d,"No");

            two.Fitting(one);

            
            Not_eating_Molecula exampl1 = new Not_eating_Molecula("Exampl1", 0.22d);
            Eating_Molecula exampl2 = new Eating_Molecula("Exampl2", 0.12d);

            exampl2.Eating(exampl1);

            Console.WriteLine(exampl1.weight);

            exampl1.Print();

        }
    }
}
