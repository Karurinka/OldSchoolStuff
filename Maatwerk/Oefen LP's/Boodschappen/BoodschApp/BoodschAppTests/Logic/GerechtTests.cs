using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoodschApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoodschApp.Logic.Tests
{
    [TestClass()]
    public class GerechtTests
    {
        private List<Product> alleProductenVoorGerecht = new List<Product>();
        private List<Product> ProductenTest = new List<Product>();


        private Gerecht gerecht;
        private Gerecht testGerecht;

        [TestInitialize]
        public void TestInitialize()
        {
            alleProductenVoorGerecht.Add(new Product(1, "Ei", "10 stuks"));
            alleProductenVoorGerecht.Add(new Product(2, "Melk", "0,5 liter"));
            alleProductenVoorGerecht.Add(new Product(3, "Bloem", "500 gram"));

            gerecht = new Gerecht(1, "Pannekoeken");
            testGerecht = new Gerecht(1, "Pannekoeken");
            gerecht.SetAlleProductenVoorGerecht(alleProductenVoorGerecht);
        }


        [TestMethod()]
        public void GetAlleProductenVoorGerechtTest()
        {
            //arrange

            //act

            //assert

        }

        [TestMethod()]
        public void SetAlleProductenVoorGerechtTest()
        {
            //arrange
            ProductenTest.Add(new Product(1, "Ei", "10 stuks"));
            ProductenTest.Add(new Product(2, "Melk", "0,5 liter"));
            ProductenTest.Add(new Product(3, "Bloem", "500 gram"));

            //act
            testGerecht.SetAlleProductenVoorGerecht(ProductenTest);

            //assert
            CollectionAssert.AreEqual(gerecht.GetAlleProductenVoorGerecht(), testGerecht.GetAlleProductenVoorGerecht(), "De inhoud van de lijsten is niet gelijk");
        }
    }
}