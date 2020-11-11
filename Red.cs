using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace spec
{
    class Red: Characteristics
    {
        Color color;

        public Red()
        {
            this.color = Color.Blue;
        }

        protected override void Print()
        {
            Console.WriteLine($"Soy el color {this.color}");
        }
    }
}