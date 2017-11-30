using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Weapon
    {
        // properties
        public string Name { get; private set; }
        public int Damage { get; private set; }

        // constructor
        public Weapon(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }

        public override string ToString()
        {
            return "Weapon name: " + Name + " " + "Damage: " + Convert.ToString(Damage);
        }
    }
}
