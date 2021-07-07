using System;
namespace CH21_Exercise
{
    public class SmartPhone : Laptop
    {

        public string PhoneNumber { get; set; }

        public static void CallNumber(string number)
        {
            Console.WriteLine($"Dialing {number}...");
            Console.WriteLine("Call Connected...");
        }

        public SmartPhone(string processor, string OS, string model, string phoneNumber) : base(processor,OS,model)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
