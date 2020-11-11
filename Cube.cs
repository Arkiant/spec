using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    class Cube : Characteristics
    {

        public Cube()
        {
            this.hp = 100;
            this.atk = 10;
        }

        protected override void Print()
        {
            Console.WriteLine("Soy un cubo");
        }
    }
}
