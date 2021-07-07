using System;
namespace CH21_Exercise
{
    public class Computer
    {
        public string Processor { get; set; }
        public string Portability { get; set; }
        public string OperatingSystem { get; set; }
        public string PowerStatus { get; set; }

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

        public void RunApplication()
        {
            Console.WriteLine("Application now Running");
        }



        public Computer(string processor, string OS)
        {
            Processor = processor;
            OperatingSystem = OS;
        }
    }
}
