using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    class Unit
    {

        int hp = 100;
        int atk = 10;

        public void Calculate(int hp, int atk)
        {
            this.hp = this.hp + (hp);
            this.atk = this.atk + (atk);
        }

        public override string ToString() => $"(HP: {this.hp}, ATK: {this.atk})";
    }
}
