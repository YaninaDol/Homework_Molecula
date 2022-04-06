using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_04_04
{
    public class Slow_move:IMove
    {
        public void MoveUp()
        {
            Console.WriteLine("Slow move Up!");

        }
        public void MoveDown()
        {
            Console.WriteLine("Slow move Down!");
        }

        public void MoveLeft()
        {
            Console.WriteLine("Slow move  Left");
        }
        public void MoveRight()
        {
            Console.WriteLine("Slow move Right!");

        }
    }
}
