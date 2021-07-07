using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CH21_Exercise;

namespace Technology_Tests1
{
    [TestClass]
    public class ComputerTests
    {
        Computer PC;
       [TestInitialize]
        public void NewComputer()
        {
           PC = new Computer("Inte-i7", "Microsoft");
        }
       [TestMethod]
       public void VerifyComputerPowersOn()
        {
            PC.Power("ON");
            Assert.AreEqual("ON", PC.PowerStatus);
        }

        public ComputerTests()
        {
        }
    }
}
