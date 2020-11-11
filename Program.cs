using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace spec
{

    class Program
    {

        static void Main(string[] args)
        {

            Unit soldado = new Unit();
            GameManager gm = new GameManager();
            ColorManager cm = new ColorManager();

            Characteristics selectSize = gm.GetSize();
            Characteristics selectedShape = gm.GetShape();
            Characteristics selectedColor = gm.GetColor();


            soldado = cm.Calculate(soldado, selectedShape, selectedColor);
            soldado = selectSize.Calculate(selectedShape.Calculate(soldado));


            Console.WriteLine(soldado);
        }
    }
}
