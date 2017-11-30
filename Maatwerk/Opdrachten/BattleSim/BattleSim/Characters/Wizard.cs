using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public class Wizard : Character
    {
        // properties
        public int Mana { get; private set; }
        public List<Spell> Spells = new List<Spell>();
        public Spell CurrentSpell { get; private set; }

        // constructor
        public Wizard(string name, int hp, int mana)
            : base(name, hp)
        {
            this.Mana = mana;
        }

        // methods
        public Spell EquipSpell(Spell spell)
        {
            CurrentSpell = spell;
            Spells.Add(spell);
            return spell;
        }

        public override int DealDamage()
        {
            if (Mana > 0)
            {
                Mana = Mana - CurrentSpell.ManaCost;
                return CurrentSpell.Damage;
            }
            else
            {
                return CurrentSpell.Damage;
            }
        }
        
        public override int ReceiveDamage(int damage)
        {
            HP = HP - damage;
            return HP;
        }

        public override bool Equals(object obj)
        {
            bool answer = false;

            if (obj is Wizard)
            {
                Wizard other = (Wizard)obj;
                bool takenDamage = this.HP.Equals(other.HP);
                answer = takenDamage;
            }

            return answer;
        }

        public override string ToString()
        {
            return base.ToString() + "Mana: " + Convert.ToString(Mana);
        }
    }
}
