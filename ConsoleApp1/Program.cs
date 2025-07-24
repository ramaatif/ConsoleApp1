// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            #region Cars application
            //intializing the Engine objects
            var GasolineEngine = new Engine("Gasoline");

            var DieselEngine = new Engine("Diesel");

            var ElectricEngine = new Engine("Electric");

            List<Car> MyCars = new List<Car>();

            Console.WriteLine("--- Initializing Cars ---");
            // Creating Car objects with different engines and properties
            var mycar = new Car("cherry", 4, GasolineEngine, "Brown", 200);
            MyCars.Add(mycar);

            var mycar2 = new Car("BMW", 4, ElectricEngine, "White", 260);
            MyCars.Add(mycar2);

            var mycar3 = new Car("Mercedes", 4, DieselEngine, "Black", 320);

            MyCars.Add(mycar3);


            Console.WriteLine("\n--- Processing Each Car ---");
            foreach (var carObject in MyCars)
            {
                // Each carObject is an instance of Car with its own properties and methods
                carObject.Drive();
                carObject.CarEngine.StartEngine();
                carObject.honk();

                Console.WriteLine($"Initialized Car: {carObject.Model} (Color: {carObject.Color}, MaxSpeed: {carObject.MaxSpeed}, Engine Type: {carObject.CarEngine.EngineType})");
                carObject.CarEngine.StopEngine();
                carObject.Stop();

                Console.WriteLine("\n");

            }

            Console.WriteLine("All Cars Processed Successfully!");
            Console.WriteLine("\n GoodBye");
            #endregion
            #region Post Testing
            //var MyPost = new Post("My First Post", "This is my first post in my blog");
            //Console.WriteLine($"Post created {MyPost.Title} in {MyPost.CreationDateTime}");
            //Console.WriteLine($"Description {MyPost.Description}");
            //Console.WriteLine($"Vote  : {MyPost.Votes}");
            //MyPost.UpVote();
            //Console.WriteLine($"After first UpVote : {MyPost.Votes}");
            //MyPost.UpVote();
            //Console.WriteLine($"After second UpVote : {MyPost.Votes}");

            //MyPost.Downvote();
            //Console.WriteLine($"After first DownVote : {MyPost.Votes}");
            //MyPost.Downvote();
            //Console.WriteLine($"After second DownVote : {MyPost.Votes}");
            //MyPost.Downvote();
            //Console.WriteLine($"After third DownVote : {MyPost.Votes}");
            //Console.WriteLine($"\nThe final result of vote :{MyPost.Votes}");
            //Console.WriteLine("\n Testing has been ended ,Goodbye");
            #endregion
            Console.ReadKey();
        }

        #region person testing
        //var person = new Person(new DateTime(2001, 4, 8));
        //Console.WriteLine("My Details:");
        //person.Name = "RamaAtif";
        //Console.WriteLine( "My Name Is :" +person.Name);
        //Console.WriteLine(person.Age +" "+"Years Old");
        //Console.WriteLine(person.PlaceOfBirth = "From Egypt");
        /////////////////////////////////////////////////////////////////////////////////////////////
        //Calculator calc = new Calculator();
        //try
        //{
        //    int result = calc.DivideRobust(10, 0); 
        //    Console.WriteLine(result);
        //}
        //catch (ArgumentException ex) // لو حصل خطأ ArgumentException امسكيه هنا
        //{
        //    Console.WriteLine($" Warning Error: {ex.Message}");
        //}
        //var calc = new Calculator();
        //int MyValue = calc.Add(1,2,3,4,5);
        //Console.WriteLine(MyValue);
        ////ref using to change the origin value of variable
        //MyValue = calc.AddFive(ref MyValue);
        //Console.WriteLine(MyValue);
        //int sumAll1 = calc.Add(10,20);
        //Console.WriteLine(sumAll1);
        //int sumAll2 = calc.Add(1,2,3,4,5,100);
        //Console.WriteLine(calc.Add(1,2,3,4,5,100));

        //     //this is a simple c# program to create a class and instantiate it
        //     var person1 = new Person
        //     {
        //         Id =1,
        //         Name = "Rama",
        //         Email = "RamaAtif@gmail.com"


        //     };
        //     var person2 = new Person
        //     {
        //         Id = 2,
        //         Name = "Mina",
        //         Email ="MinaMosa@gmail.com"

        //     };

        //     Console.WriteLine(person1.Name);
        //     Console.WriteLine(person1.Id);
        //     Console.WriteLine(person1.Email);

        //     Console.WriteLine("\n");

        //     Console.WriteLine(person2.Name);
        //     Console.WriteLine(person2.Id);
        //     Console.WriteLine(person2.Email);
        #endregion

    }

}


