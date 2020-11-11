using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    class Randomize
    {
        public static Characteristics Rand(List<Characteristics> characteristics)
        {
            Random randomize = new Random();
            int position = randomize.Next(0, characteristics.Count);
            return characteristics[position];

        }
    }
}
