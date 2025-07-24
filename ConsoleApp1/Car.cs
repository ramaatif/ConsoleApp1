using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Vehicle //inheritance relationship with Vehicle
    {
        //Car class has properties Model,NumbersOfDoors and methods honk and constructor
        public string Model { get; set; }
        public int NumbersOfDoors { get; set; }
        public Engine CarEngine { get; set; }   //composition relationship with Engine car has an engine
        // Constructor to initialize model, number of doors, engine, color, and max speed
        public Car(string model, int numberofdoors, Engine engine, string color, int maxspeed)
            : base(color, maxspeed) //calling the base class constructor to initialize color and max speed
        {
            Model = model;
            NumbersOfDoors = numberofdoors;
            CarEngine = engine;
        }
        public void honk()
        {
            Console.WriteLine("Car is honking");
        }
       public override void Drive() //overriding the Drive method from Vehicle class
        {
            Console.WriteLine($"{Model} is driving");
        }
        public override void Stop() //overriding the Stop method from Vehicle class
        {
            Console.WriteLine($"{Model} has stopped");
        }
    }    //inheritance relationship with Vehicle
}