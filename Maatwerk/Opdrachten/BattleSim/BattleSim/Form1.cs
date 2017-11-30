using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReloadForm();
        }

        // fields
        private Knight knight = new Knight("Pop", 250, 50);
        private Wizard wizard = new Wizard("Wizi", 200, 100);
        private Weapon weapon1 = new Weapon("Cleaver", 20);
        private Weapon weapon2 = new Weapon("Dagger", 10);
        private Spell spell1 = new Spell("Fireball", 30, 10);

        // methods
        public void ReloadForm()
        {
            lblKnightName.Text = knight.Name;
            lblWizardName.Text = wizard.Name;

            pbKnightHP.Value = knight.HP;
            pbShieldPower.Value = knight.ShieldPower;
            pbWizardHP.Value = wizard.HP;
            pbMana.Value = wizard.Mana;

            knight.EquipWeapon(weapon1);
            wizard.EquipWeapon(weapon2);
            wizard.EquipSpell(spell1);
        }


        private void btnKnightAttack_Click(object sender, EventArgs e)
        {
            wizard.ReceiveDamage(knight.DealDamage());
            ReloadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            knight.ReceiveDamage(wizard.DealDamage());
            ReloadForm();
        }
    }
}
