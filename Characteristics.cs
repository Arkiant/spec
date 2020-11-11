using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace spec
{
    abstract class Characteristics
    {

        protected int hp = 0;
        protected int atk = 0;

        virtual public Unit Calculate(Unit unit)
        {
            this.Print();
            unit.Calculate(this.hp, this.atk);
            return unit;
        }

        abstract protected void Print();
    }
}
