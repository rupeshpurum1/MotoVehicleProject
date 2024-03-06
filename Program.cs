using System;

namespace MotoVehicleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Vehicle
            Vehicle myVehicle = new Vehicle();

            // Setting values for the fields
            myVehicle.make = "Toyota";
            myVehicle.type = "SUV";
            myVehicle.color = "Red";
            myVehicle.speed = 60;

            // Displaying information about the vehicle
            Console.WriteLine($"Make: {myVehicle.make}");
            Console.WriteLine($"Type: {myVehicle.type}");
            Console.WriteLine($"Color: {myVehicle.color}");
            Console.WriteLine($"Speed: {myVehicle.speed} mph");
            Console.WriteLine($"Made In: {myVehicle.madeIn}");

            // Stopping the vehicle
            myVehicle.stopVehicle();
            Console.WriteLine($"Vehicle stopped. Speed: {myVehicle.speed} mph");

            Console.ReadLine();
        }
    }
}
