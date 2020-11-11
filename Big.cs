using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    class Big : Characteristics
    {
        public Big()
        {
            this.hp = 50;
            this.atk = 0;
        }

        protected override void Print()
        {
            Console.WriteLine("Soy grande");
        }
    }
}
