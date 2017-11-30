using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_VJ_SE2_BP3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_VJ_SE2_BP3.Classes.Tests
{
    [TestClass()]
    public class VoertuigTests
    {
        private int KilometerPerLiter;
        private Auto TestAuto;
        private Auto CorrecteAuto;
        private bool Ingarage;

        [TestMethod(), TestInitialize]
        public void VoertuigTest()
        {
            KilometerPerLiter = 5;
            TestAuto = new Auto("pp0i", KilometerPerLiter, 2);
            CorrecteAuto = new Auto("pp0i", 10, 3);
            Ingarage = true;
        }

        [TestMethod()]
        public void Test_GetInGarage()
        {
            //arrange
            TestAuto.SetInGarage(Ingarage);

            //act

            //assert
            Assert.AreEqual(TestAuto.GetInGarage(), TestAuto.InGarage, "Beide voertuigen hebben niet dezelfe InGarage");
        }


        [TestMethod()]
        //test de SetInGarage methode
        //test de SetInGarage methode
        //deze methode zet de ingarage property
        //of wel de ingarage bool wordt op true gezet
        public void Test_SetInGarage()
        {
            //arrange

            //act 
            TestAuto.SetInGarage(Ingarage);

            //assert
            Assert.AreEqual(true, TestAuto.InGarage, "Beide voertuigen hebben niet dezelfde InGarage");
        }

        [TestMethod()]
        //test de BerekenVerbruikteBrandstof
        //deze methode berekent de prijs van de verbruikte brandstof
        public void Test_BerekenVerbruikteBrandstof()
        {
            //arrange
            int kilometers = 10;

            //act 
            TestAuto.BerekenVerbruikteBrandstof(kilometers);

            //assert
            Assert.AreEqual(2, TestAuto.BerekenVerbruikteBrandstof(kilometers), "De twee voertuigen hebben niet hetzelfde aantal verbruikte brandstof");
        }

        [TestMethod()]
        //deze test kijkt als er een auto vergeleken wordt met
        //een auto met hetzelfe kenteken
        //de compare to dit ziet als een en dezelfde
        public void Test_CompareTo()
        {
            //arrange

            //act
            
            //assert
            Assert.AreEqual(CorrecteAuto.Kenteken, TestAuto.Kenteken, "De twee auto's hebben niet hetzelfde kenteken");
        }
    }
}