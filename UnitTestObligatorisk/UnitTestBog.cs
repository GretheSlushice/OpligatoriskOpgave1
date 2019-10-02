using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpligatoriskOpgave1;

namespace UnitTestObligatorisk
{
    [TestClass]
    public class UnitTestBog
    {
        private Bog newBog;

        [TestInitialize]
        public void BeforeTest()
        {
            newBog = new Bog("Den grimme ælling", "H. C. Andersen", 10, "AF34Kk3J87ez2");
        }


        //Tester kreation af nyt objekt
        [TestMethod]
        public void TestCreateBog()
        {
            Assert.AreEqual(newBog.Titel, "Den grimme ælling");
            Assert.AreEqual(newBog.Forfatter, "H. C. Andersen");
            Assert.AreEqual(newBog.SideTal, 10);
            Assert.AreEqual(newBog.Isbn13, "AF34Kk3J87ez2");
        }

        //Tester opdateringen af objektet
        [TestMethod]
        public void TestUpdateBog()
        {
            newBog.Titel = "Den dumme ælling";
            Assert.AreEqual(newBog.Titel, "Den dumme ælling");
            newBog.Forfatter = "Jens Jensen";
            Assert.AreEqual(newBog.Forfatter, "Jens Jensen");
            newBog.SideTal = 1000;
            Assert.AreEqual(newBog.SideTal, 1000);
            newBog.Isbn13 = "AAAAAAAAAAAAA";
            Assert.AreEqual(newBog.Isbn13, "AAAAAAAAAAAAA");
        }

        //Tester at constraint for titlen virker
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestTitel()
        {
            newBog.Titel = " ";
        }

        //Tester at constraint for sidetallet virker
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSideTal1()
        {
            newBog.SideTal = 9;
        }

        //Tester at constraint for sidetallet virker
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSideTal2()
        {
            newBog.SideTal = 1001;
        }

        //Tester at constraint for Isbn13 virker
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestIsbn13()
        {
            newBog.Isbn13 = "13333";
        }
    }
}
