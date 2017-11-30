using Microsoft.VisualStudio.TestTools.UnitTesting;
using VogeltellersASP.Models.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogeltellersASP.Models.Logic.Tests
{
    [TestClass()]
    public class BezoekTests
    {
        Waarneming TestWaarneming;

        Bezoek TestBezoek;

        Vogelsoort TestVogel1;
        Vogelsoort TestVogel2;

        [TestInitialize]
        public void TestInitialize()
        {
            TestWaarneming = new Waarneming(1, 2, "Territorium Indicerend", "TI", 2);

            TestBezoek = new Bezoek(1, 1, 0, DateTime.Now);

            TestVogel1 = new Vogelsoort(1, "Appelvink", "AV", DateTime.Now, DateTime.Now, 3);
            TestVogel2 = new Vogelsoort(2, "Blauwe Reiger", "BLR", DateTime.Now, DateTime.Now, 5);
        }

        [TestMethod()]
        public void BekijkWaarnemingDetails()
        {
            //arrange
            //arrange gedaan in de testinitialize

            //act
            Console.WriteLine(TestWaarneming);
            
            //assert
        }

        [TestMethod()]
        public void HaalWaarnemingenOpTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BerekenBroedpaarTest()
        {
            //arrange

            //act
            int uitkomst = TestBezoek.BerekenBroedpaar(TestVogel1);

            //assert
            Assert.AreEqual(0, uitkomst);
        }

        [TestMethod()]
        public void DraaiWaarnemingUitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ZoekWaarnemingTest()
        {
            Assert.Fail();
        }
    }
}