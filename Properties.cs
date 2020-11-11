using System;
using System.Collections.Generic;
using System.Text;

namespace spec
{
    public struct Properties
    {

        public Properties(int hp, int atk)
        {
            HP = hp;
            ATK = atk;
        }

        public int HP { get; set; }
        public int ATK { get; set; }

        public void InsertValues(int hp, int atk)
        {
            this.HP = this.HP + (hp);
            this.ATK = this.ATK + (atk);
        }

        public override string ToString() => $"(HP: {HP}, ATK: {ATK})";
    }
}
