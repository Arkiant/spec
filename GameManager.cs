using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace spec
{
    class GameManager
    {
        List<Characteristics> shapes = new List<Characteristics>();
        List<Characteristics> colors = new List<Characteristics>() { new Blue(), new Yellow(), new Green(), new Red() };

        public GameManager()
        {
            shapes.Add(new Sphere());
            shapes.Add(new Cube());
        }


        public Characteristics GetColor()
        {
            Characteristics selectedColor = Randomize.Rand(colors);
            return selectedColor;
        }

        public Characteristics GetShape()
        {
            Characteristics selectedShape = Randomize.Rand(shapes);
            return selectedShape;
        }

        public Characteristics GetSize()
        {
            SizeManager sm = new SizeManager();
            return sm.GetRandom();
        }
    }
}
