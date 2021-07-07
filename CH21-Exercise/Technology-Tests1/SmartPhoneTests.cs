using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CH21_Exercise;



namespace Technology_Tests1
{
    [TestClass]
    public class SmartPhoneTests
    {
        SmartPhone nicePhone;
        [TestInitialize]
        public void newPhone()
        {
            nicePhone = new SmartPhone("A14 Bionic", "Apple", "12", "123-123-1234");
        }
        [TestMethod]
        public void verifyPhoneNumber()
        {
            Assert.AreEqual("123-123-1234",nicePhone.PhoneNumber);
        }

        [TestMethod]
        public void verifyDeviceSetsSecurity()
        {
            nicePhone.SetSecurity("Fingerprint Unlock");
            Assert.AreEqual("Fingerprint Unlock", nicePhone.SecurityType);
        }

        [TestMethod]
        public void VerifyArgumentExceptionThrown()
        {
            try
            {
                nicePhone.SetSecurity("GG");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Unexpected Argument: Try; Fingerprint Unlock, Face Unlock, Pin, Password", ex.Message);
            }
        }

        [TestMethod]
        public void VerifyIDIsSet()
        {
            Console.WriteLine(nicePhone.deviceID);
        }
        public SmartPhoneTests()
        {
        }
    }
}
