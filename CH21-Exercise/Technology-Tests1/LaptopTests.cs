using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CH21_Exercise;


namespace Technology_Tests1
{

    [TestClass]
    public class LaptopTests
    {
        Laptop newLaptop;
        [TestInitialize]
        public void NewLaptop()
        {
            newLaptop = new Laptop("intel Core i5-8500", "MacOS","2020_13");
        }
        [TestMethod]
        public void VerifyLaptopLocks()
        {
            newLaptop.LockDevice();
            Assert.AreEqual("Locked", newLaptop.LockStatus);
        }

        [TestMethod]
        public void VerifyProcessor()
        {
            Assert.AreEqual("intel Core i5-8500", newLaptop.Processor);
        }

        [TestMethod]
        public void VerifyModel()
        {
            Assert.AreEqual("2020_13", newLaptop.Model);
        }


        public LaptopTests()
        {
        }
    }
}
