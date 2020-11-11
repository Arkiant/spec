using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace spec
{
    class Green: Characteristics
    {
        Color color;

        public Green()
        {
            this.color = Color.Green;
        }

        protected override void Print()
        {
            Console.WriteLine($"Soy el color {this.color}");
        }
    }
}