using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_04_04
{
   public class Fast_move:IMove
    {
        public void MoveUp()
        {
            Console.WriteLine("Fast move Up!");

        }
        public void MoveDown()
        {
            Console.WriteLine("Fast move Down!");
        }
       
        public void MoveLeft()
        {
            Console.WriteLine("Fast move  Left");
        }
        public void MoveRight()
        {
            Console.WriteLine("Fast move Right!");

        }
    }
}
