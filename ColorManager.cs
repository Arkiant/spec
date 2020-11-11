using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace spec
{
    class ColorManager
    {

        Dictionary<(System.Type, System.Type), (int, int)> map = new Dictionary<(System.Type, System.Type), (int, int)>();
        public ColorManager()
        {
            map.Add((typeof(Sphere), typeof(Blue)), (50, 0));
            map.Add((typeof(Sphere), typeof(Yellow)), (0, 20));
            map.Add((typeof(Sphere), typeof(Green)), (150, 0));
            map.Add((typeof(Sphere), typeof(Red)), (0, 40));

            map.Add((typeof(Cube), typeof(Blue)), (0, 10));
            map.Add((typeof(Cube), typeof(Yellow)), (100, 0));
            map.Add((typeof(Cube), typeof(Green)), (0, 30));
            map.Add((typeof(Cube), typeof(Red)), (200, 0));
        }

        public Unit Calculate(Unit unit, Characteristics selectedShape, Characteristics selectedColor)
        {
            (int, int) values = this.map[(selectedShape.GetType(), selectedColor.GetType())];
            unit.Calculate(values.Item1, values.Item2);
            selectedColor.Calculate(unit);
            return unit;
        }

    }
}
