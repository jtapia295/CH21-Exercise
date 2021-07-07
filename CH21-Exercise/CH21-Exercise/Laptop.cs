using System;
namespace CH21_Exercise
{
    public class Laptop : Computer
    {
        public string Model { get; set; }
        public string PowerMode { get; set; }
        public string LockStatus { get; set; }
        public string SecurityType { get; set; }
        //public string deviceID { get; set; }

        public void EnablePowerSaving()
        {
            PowerMode = "Power Saving";
        }

        public void LockDevice()
        {
            LockStatus = "Locked";
            Console.WriteLine($"Device is now {LockStatus}");
        }

        public void SetSecurity(string securitySet)
        {
            if(securitySet.ToLower().Contains("fingerprint") || securitySet.ToLower().Contains("face") || securitySet.ToLower() == "pin" || securitySet.ToLower() == "password")
            {
                SecurityType = securitySet;
            }
            else
            {
                throw new ArgumentException("Unexpected Argument: Try; Fingerprint Unlock, Face Unlock, Pin, Password");
            }
        }

        public Laptop()
        {
            Portability = "Mobile";
        }

        public Laptop(string processor, string OS, string model) :
            base(processor, OS)
        {
            Portability = "Mobile";
            Model = model;
        }
    }
}
