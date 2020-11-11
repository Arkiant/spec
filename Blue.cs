using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace spec
{
    class Blue:Characteristics
    {
        Color color;

        public Blue()
        {
            this.color = Color.Blue;
        }
        protected override void Print()
        {
            Console.WriteLine($"Soy el color {this.color}");
        }
    }
}
