using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoodschApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BoodschApp.Logic.Product;

namespace BoodschApp.Logic.Tests
{
    [TestClass()]
    public class LijstTests
    {
        private List<Product> huidigeProductenGesorteerd = new List<Product>();
        private List<Product> huidigeProducten = new List<Product>();

        private Product testProduct1;
        private Product testProduct2;
        private Product testProduct3;
        
        private SorteerOpLooproute sorteerOpLooproute = new SorteerOpLooproute();

        [TestInitialize]
        public void TestInitialize()
        {
            testProduct1 = new Product(1, "Ei", "10 stuks");
            testProduct2 = new Product(2, "Melk", "0,5 liter");
            testProduct3 = new Product(3, "Bloem", "500 gram");

            huidigeProductenGesorteerd.Add(testProduct3);
            huidigeProductenGesorteerd.Add(testProduct1);
            huidigeProductenGesorteerd.Add(testProduct2);
        }

        [TestMethod()]
        public void SorteerTest()
        {
            //arrange
            huidigeProducten.Add(testProduct1);
            huidigeProducten.Add(testProduct2);
            huidigeProducten.Add(testProduct3);

            //act
            huidigeProducten.Sort(sorteerOpLooproute);

            //assert
            CollectionAssert.AreEqual(huidigeProductenGesorteerd, huidigeProducten, "De inhoud van de lijsten is niet gelijk");
        }

        [TestMethod()]
        public void SetAlleProductenTest()
        {
            //arrange

            //act
            
            //assert
        }

        [TestMethod()]
        public void ProductToevoegenTest()
        {
            //arrange

            //act

            //assert
        }

        [TestMethod()]
        public void GerechtToevoegenTest()
        {
            //arrange

            //act

            //assert
        }
    }
}