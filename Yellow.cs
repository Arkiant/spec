using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace spec
{

    class Yellow: Characteristics
    {
        Color color;

        public Yellow()
        {
            this.color = Color.Yellow;
        }

        protected override void Print()
        {
            Console.WriteLine($"Soy el color {this.color}");
        }
    }
}