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
           PC = new Computer("Intel-i7", "Microsoft");
        }
       [TestMethod]
       public void VerifyComputerPowersOn()
        {
            PC.Power("ON");
            Assert.AreEqual("on", PC.PowerStatus);
        }

        [TestMethod]
        public void VerifyComputerRunsApplication()
        {
            PC.RunApplication();
            Assert.AreEqual("Application now running", PC.RunApplication());
        }

        [TestMethod]
        public void VerifyOperatingSystem()
        {
            Assert.AreEqual("Microsoft", PC.OperatingSystem);
        }

        [TestMethod]
        public void VerifyProcessor()
        {
            Assert.AreEqual("Intel-i7", PC.Processor);
        }

        [TestMethod]
        public void VerifyPortability()
        {
            Assert.AreEqual("Desktop",PC.Portability);
        }

        public ComputerTests()
        {
        }
    }
}
