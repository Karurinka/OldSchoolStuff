using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Knight : Character
    {
        // propeties
        public int ShieldPower { get; private set; }

        // constructor
        public Knight(string name, int hp, int shieldpower)
            : base(name, hp)
        {
            this.ShieldPower = shieldpower;
        }

        // methods
        public override int DealDamage()
        {
            return EquippedWeapon.Damage;
        }

        public override int ReceiveDamage(int damage)
        {
            if (ShieldPower > 0)
            {
                ShieldPower = ShieldPower - damage;
                return damage;
            }
            else
            {
                HP = HP - damage;
                return HP;
            }
        }

        public override bool Equals(object obj)
        {
            bool answer = false;

            if (obj is Knight)
            {
                Knight other = (Knight)obj;
                if (ShieldPower <= 0)
                {
                    bool takenDamage = this.HP.Equals(other.HP);
                    answer = takenDamage;
                }
                else
                {
                    bool takenDamage = this.ShieldPower.Equals(other.ShieldPower);
                    answer = takenDamage;
                }
            }
            return answer;
        }

        public override string ToString()
        {
            return base.ToString() + "Shield: " + ShieldPower;
        }
    }
}
