using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_04_04
{
    public class Molecula
    {
        public string Name { get; set; }
        public double weight { get; set; }
        public IMove Move { get; set; }
        public IAtaka Atack { get; set; }
        protected string Eat { get; set; }


        public Molecula(string name, double weight,string eat)
        {
            Name = name;
            this.weight = weight;

        }

        public Molecula():this("Name",0.00f,"Yes")
        {
        }

        public void Fitting (Molecula other)
        {

            if (other.weight > this.weight)
            {


                if (other.weight - this.weight > 0.10d)

                {
                    other.Atack = new To_Atak();
                    other.Move = new Fast_move();

                    Atack = new Ataka_from();
                    Move = new Fast_move();

                    other.Atack.Strong_Atak();
                    other.Atack.Strong_Atak();
                    Atack.Strong_Atak();
                    Atack.Strong_Atak();


                    Move.MoveDown();
                    Move.MoveDown();
                    Move.MoveDown();
                    Move.MoveDown();
                }


                else
                {
                    other.Atack = new To_Atak();
                    other.Move = new Slow_move();

                    Atack = new Ataka_from();
                    Move = new Slow_move();

                    other.Atack.Little_Atak();
                    Atack.Little_Atak();

                    Move.MoveLeft();
                    other.Move.MoveRight();

                    other.Atack.Little_Atak();
                    Atack.Little_Atak();

                    Move.MoveDown();
                    Move.MoveDown();
                }
            }

            else
            {

                if (this.weight - other.weight > 0.10d)

                {
                    Atack = new To_Atak();
                    Move = new Fast_move();

                    other.Atack = new Ataka_from();
                    other.Move = new Fast_move();

                    Atack.Strong_Atak();
                    other.Atack.Strong_Atak();

                    Atack.Strong_Atak();
                    other.Atack.Strong_Atak();

                    other.Move.MoveLeft();
                    other.Move.MoveLeft();
                    other.Move.MoveLeft();
                }


                else
                {
                    Atack = new To_Atak();
                    Move = new Slow_move();

                    other.Atack = new Ataka_from();
                    other.Move = new Slow_move();

                    Atack.Little_Atak();
                    other.Atack.Little_Atak();

                    other.Move.MoveLeft();
                    Move.MoveRight();

                    Atack.Little_Atak();
                    other.Atack.Little_Atak();

                    other.Move.MoveDown();
                    other.Move.MoveDown();

                }
            }
        }

       


    }
}
