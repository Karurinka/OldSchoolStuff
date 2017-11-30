using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Character
    {
        // properties
        public string Name { get; private set; }
        public int HP { get; set; }
        public List<Weapon> Weapons { get; private set; }
        public Weapon EquippedWeapon { get; private set; }

        // constructor
        public Character(string name,  int hp)
        {
            this.Name = name;
            this.HP = hp;
        }

        // methods
        public virtual int DealDamage()
        {
            return 1;
        }

        public virtual int ReceiveDamage(int damage)
        {
            return 1;
        }

        public Weapon EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
            return weapon;
        }

        public override string ToString()
        {
            return "Name: " + Name + "HP: " + HP + "Weapon: " + Convert.ToString(EquippedWeapon);
        }
    }
}
