using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Laptop
    {
        public string Brand { get; set; }
        private bool isConnected;
        private int batteryPercentage;
        public Laptop(string brand)
        {
            Brand = brand;
            batteryPercentage = 0;
        }
        public bool Connect()
        {
            Console.WriteLine($"Connecting {Brand} laptop...");
            isConnected = true;
            Console.WriteLine($"{Brand} laptop successfully connected!!");
            return true;
        }
        public void Charge(int minutes)
        {
            Console.WriteLine($"Charging {Brand} laptop for {minutes} minutes");
            batteryPercentage += minutes / 2;
            if (batteryPercentage > 100)
                batteryPercentage = 100;
            Console.WriteLine($"{Brand} laptop is now charged to {batteryPercentage}%");
        }
        public string Display()
        {
            return $"Laptop Brand: {Brand}, Battery: {batteryPercentage}%";
        }
    }

}
