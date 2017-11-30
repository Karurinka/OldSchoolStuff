using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Spell
    {
        // properties
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public int ManaCost { get; private set; }

        // constructor
        public Spell(string name, int damage, int manacost)
        {
            this.Name = name;
            this.Damage = damage;
            this.ManaCost = manacost;
        }
    }
}
