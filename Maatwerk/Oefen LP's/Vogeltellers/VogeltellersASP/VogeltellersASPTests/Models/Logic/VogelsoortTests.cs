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
    public class VogelsoortTests
    {
        Vogelsoort_SorteerOpBroedpaarCijfer SorteerOpCijfer;
        Vogelsoort_SorteerOpVogelnaam SorteerOpNaam;

        Vogelsoort Testvogel1;
        Vogelsoort TestVogel2;

        List<Vogelsoort> Vogels;
        List<Vogelsoort> TestVogels;

        [TestInitialize]
        public void TestInitialize()
        {
            SorteerOpCijfer = new Vogelsoort_SorteerOpBroedpaarCijfer();
            SorteerOpNaam = new Vogelsoort_SorteerOpVogelnaam();

            Testvogel1 = new Vogelsoort(1, "Appelvink", "AV", DateTime.Now, DateTime.Now, 3);
            TestVogel2 = new Vogelsoort(2, "Blauwe Reiger", "BLR", DateTime.Now, DateTime.Now, 5);

            Vogels = new List<Vogelsoort>();
            TestVogels = new List<Vogelsoort>();
        }

        [TestMethod()]
        public void SorteerVogelOpNaam_Test()
        {
            //arrange
            //deels gedaan in de test initialize
            Vogels.Add(Testvogel1);
            Vogels.Add(TestVogel2);

            //act
            TestVogels.Add(TestVogel2);
            TestVogels.Add(Testvogel1);

            TestVogels.Sort(SorteerOpNaam);

            //asset
            CollectionAssert.AreEqual(Vogels, TestVogels, "De inhoud van de lijsten zijn niet gelijk");
        }

        [TestMethod()]
        public void SorteerVogelOpCijfer_Test()
        {
            //arrange
            Vogels.Add(TestVogel2);
            Vogels.Add(Testvogel1);

            //act
            TestVogels.Add(Testvogel1);
            TestVogels.Add(TestVogel2);

            TestVogels.Sort(SorteerOpCijfer);

            //assert
            CollectionAssert.AreEqual(Vogels, TestVogels, "De inhoud van de lijsten zijn niet gelijk");
        }
    }
}