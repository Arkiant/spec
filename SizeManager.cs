using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    class SizeManager
    {
        List<Characteristics> sizes = new List<Characteristics>();

        public SizeManager()
        {
            sizes.Add(new Small());
            sizes.Add(new Big());
        }

        public Characteristics GetRandom()
        {
            Characteristics selectSize = Randomize.Rand(sizes);
            return selectSize;
        }
    }
}
