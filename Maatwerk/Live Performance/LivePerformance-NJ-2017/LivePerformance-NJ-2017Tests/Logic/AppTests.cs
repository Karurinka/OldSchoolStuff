using Microsoft.VisualStudio.TestTools.UnitTesting;
using LivePerformance_NJ_2017.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic.Tests
{
    [TestClass()]
    public class AppTests
    {
        List<Uitslag> TestUitslagenGoed;
        [TestInitialize]
        public void TestInitialize()
        {
            TestUitslagenGoed = new List<Uitslag>();
        }

        public int BepaalMeerderheid()
        {
            int totaal = 0;
            foreach (Uitslag u in TestUitslagenGoed)
            {
                totaal = totaal + u.Zetels;
            }

            int meerderheid = 0;

            if (totaal < 150)
            {
                meerderheid = totaal / 2 + 1;
            }

            return meerderheid;
        }

        [TestMethod()]
        public void BepaalMeerderheidTest()
        {
            //arrange

            Uitslag uitslag1 = new Uitslag("Test", 12, 50);
            Uitslag uitslag2 = new Uitslag("Test2", 12, 102);

            TestUitslagenGoed.Add(uitslag1);
            TestUitslagenGoed.Add(uitslag2);

            //act

            //assert
            //zorg ervoor dat de zetels > 150 zijn om te laten zien dat
            //als dit gebeurt er een lege meerderheid wordt teruggegeven
            //zodat je kan zien dat hij nooit 150 zal overschrijden
            Assert.AreEqual(BepaalMeerderheid(), 0, "De meerderheid is kleiner dan 150");
        }
    }
}