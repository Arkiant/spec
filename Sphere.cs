using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    class Sphere : Characteristics
    {

        public Sphere()
        {
            this.hp = 50;
            this.atk = 20;
        }

        protected override void Print()
        {
            Console.WriteLine("Soy una esfera");
        }
    }
}
