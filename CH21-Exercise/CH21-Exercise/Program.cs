using System;

namespace CH21_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone iphone = new SmartPhone("A14", "IOS", "12", "123-123-1234");
            Laptop example = new Laptop("intel core i5-8500", "MacOS", "2020 13'");
           
            Console.WriteLine("<------------------------------------>");
            Console.WriteLine(iphone.GetID());
            Console.WriteLine("<------------------------------------>");
            Console.WriteLine(example.GetID());



        }
    }
}
