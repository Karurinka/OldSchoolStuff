using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim.Tests
{
    [TestClass()]
    public class CharacterTests
    {
        // fields 
        private Wizard wizard;
        private Knight knight;

        [TestInitialize]
        public void Initialize()
        {
            wizard = new Wizard("Wizi", 100, 150);
            knight = new Knight("TestSubject", 200, 50);
        }

        [TestMethod()]
        public void Knight_Equipping_Other_Weapon()
        {
            // arrange
            Knight correctKnight = new Knight("TestSubject", 200, 50);
            Weapon sword = new Weapon("Sword", 15);
            Weapon axe = new Weapon("Axe", 30);
            knight.EquipWeapon(sword);
            correctKnight.EquipWeapon(axe);

            // act
            knight.EquipWeapon(axe);

            // assert
            Assert.AreEqual(correctKnight.EquippedWeapon, knight.EquippedWeapon);
        }

        [TestMethod()]
        public void Wizard_Deal_Damage_To_Knight_Test()
        {
            // arrange
            Knight hurtKnight = new Knight("Jan", 200, 40);
            Spell spell = new Spell("Fireball", 10, 20);
            wizard.EquipSpell(spell);

            // act
            knight.ReceiveDamage(wizard.DealDamage());

            // assert
            Assert.AreEqual(hurtKnight, knight, "The two knights don't have the same amount of HP");
        }

        [TestMethod()]
        public void Knight_Deal_Damage_To_Wizard_Test()
        {
            // arrange
            Wizard hurtWizard = new Wizard("Wizi", 85, 150);
            Weapon sword = new Weapon("Sword", 15);
            knight.EquipWeapon(sword);

            // act
            wizard.ReceiveDamage(knight.DealDamage());

            // assert
            Assert.AreEqual(hurtWizard, wizard, "the two wizards don't have the same amount of HP");
        }
    }
}