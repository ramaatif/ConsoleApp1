using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicle //vehicle class has properties color,maxspeed and methods Drive and Stop and constructor
    {
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        // Constructor to initialize color and maxSpeed
        public Vehicle(string color, int maxSpeed)
        {
            Color = color; 
            MaxSpeed = maxSpeed;
        }
        // Virtual methods that can be overridden in derived classes
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle start driving");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }

    }
}
