using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Smartphone : IConnectable, IRechargable, IDisplayable
    {
        public string Model { get; set; }
        private bool isConnected;
        private int batteryPercentage;
        public Smartphone(string model)
        {
            Model = model;
            batteryPercentage = 0;
        }
        public bool Connect()
        {
            Console.WriteLine($"Connecting Phone {Model}...");
            isConnected = true;
            Console.WriteLine($"Phone {Model} successfully connected!!");
            return true;
        }
        public void Charge(int minutes)
        {
            Console.WriteLine($"Charging Phone {Model} for {minutes} minutes");
            batteryPercentage += minutes * 2;
            if (batteryPercentage > 100)
                batteryPercentage = 100;
            Console.WriteLine($"Phone {Model} is now charged to {batteryPercentage}%");
        }
        public string Display()
        {
            return $"Smartphone Model: {Model}, Battery: {batteryPercentage}%";
        }
    }
}