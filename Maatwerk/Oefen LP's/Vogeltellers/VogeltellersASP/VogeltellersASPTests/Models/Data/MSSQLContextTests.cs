using Microsoft.VisualStudio.TestTools.UnitTesting;
using VogeltellersASP.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VogeltellersASP.Models.Logic;

namespace VogeltellersASP.Models.Data.Tests
{
    [TestClass()]
    public class MSSQLContextTests
    {
        public IContext Context;
        public MSSQLContext SQLContext;

        [TestInitialize]
        public void TestInitialize()
        {
            SQLContext = new MSSQLContext(Context);
        }


        [TestMethod()]
        public void GetAllBezoekenTest()
        {
            //arrange
            List<Bezoek> TestBezoeken = new List<Bezoek>();

            //act
            //SQLContext.GetAllBezoeken();
            TestBezoeken.Add(new Bezoek(1, 1, 0, DateTime.Now.Date));
            TestBezoeken.Add(new Bezoek(2, 2, 0, DateTime.Now.Date));
            TestBezoeken.Add(new Bezoek(3, 3, 0, DateTime.Now.Date));

            //assert
            //het datum format in de database komt niet overeen met het datum format in c#

            Assert.AreEqual(TestBezoeken, SQLContext.GetAllBezoeken(), "De inhoud van de lists zijn niet hetzelfde");
        }

        [TestMethod()]
        public void GetAllProjectenTest()
        {
            //arrange
            List<Project> TestProjecten = new List<Project>();
            List<Project> UitgelezenProjecten = new List<Project>();

            //act
            TestProjecten.Add(new Project(1, "Test", "Heide"));
            UitgelezenProjecten = SQLContext.GetAllProjecten();

            //assert
            //collectionasserts is nodig om equals uit te voeren op lists
            //als niets in de code fout is -> google
            CollectionAssert.AreEqual(TestProjecten, UitgelezenProjecten, "De inhoud van de list komen niet overeen");
        }

        [TestMethod()]
        public void InsertWaarnemingTest()
        {
            //arrange
            //Waarneming TestWaarneming = new Waarneming(10, 1, "Territorium Indicerend", "TI", 2);
            Waarneming InsertWaarneming = new Waarneming(10, 1, "Territorium Indicerend", "TI", 2);
            bool Geïnsert = true;

            //act
            //SQLContext.InsertWaarneming(InsertWaarneming);

            //assert
            Assert.AreEqual(Geïnsert, SQLContext.InsertWaarneming(InsertWaarneming));
        }

        [TestMethod()]
        public void InsertProjectTest()
        {
            Assert.Fail();
        }
    }
}