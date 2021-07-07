using System;
namespace CH21_Exercise
{
    public class Laptop : Computer
    {
        public string Model { get; set; }
        public string PowerMode { get; set; }
        public string LockStatus { get; set; }
        public string SecurityType { get; set; }

        public void EnablePowerSaving()
        {
            PowerMode = "Power Saving";
        }

        public void LockDevice()
        {
            LockStatus = "Locked";
            Console.WriteLine($"Device is now {LockStatus}");
        }

        public void SetSecurity()
        {
            Console.WriteLine("Type one of the available security options: Fingerprint Unlock, Face Unlock, Pin, Password");
            string securitySet = Console.ReadLine();
            if(securitySet.ToLower().Contains("fingerprint") || securitySet.ToLower().Contains("face") || securitySet.ToLower() == "pin" || securitySet.ToLower() == "password")
            {
                SecurityType = securitySet;
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
