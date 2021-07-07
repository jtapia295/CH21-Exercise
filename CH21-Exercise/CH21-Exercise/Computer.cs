using System;
namespace CH21_Exercise
{
    public class Computer : AbsractEntity
    {
        public string Processor { get; set; }
        public string Portability { get; set; }
        public string OperatingSystem { get; set; }
        public string PowerStatus { get; set; }
        //public string deviceID { get; set; }

        public void Power(string status)
        {
            if(status.ToLower() == "on")
            {
                PowerStatus = status.ToLower();
            }
            else if (status.ToLower() == "off")
            {
                PowerStatus = status.ToLower();
            }
            Console.WriteLine($"Your {Portability} system is now {PowerStatus}");
                   
        }

        public string RunApplication()
        {
            string message = "Application now running";
            Console.WriteLine(message);

            return message;
        }

        public Computer()
        {
            Portability = "Desktop";
        }

        public Computer(string processor, string OS)
        {
            Processor = processor;
            OperatingSystem = OS;
            Portability = "Desktop";
        }
    }
}
