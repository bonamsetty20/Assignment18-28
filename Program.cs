using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("OnePlus10");
            smartphone.Connect();
            smartphone.Charge(80);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop("Dell");
            laptop.Connect();
            laptop.Charge(90);
            Console.WriteLine(laptop.Display());
        }
    }
}
