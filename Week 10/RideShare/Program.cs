using System;
using System.Collections.Generic;
using RideShare.Models;

namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create cars, motorbikes and luxury cars in the user's vicinity
			var car1 = new Car {
				DistanceAwayInKm = 4.5
			};

			var car2 = new Car {
				DistanceAwayInKm = 1.2
			};

			var luxuryCar1 = new LuxuryCar {
				DistanceAwayInKm = 0.6
			};
			
			var extraLargeCar1 = new ExtraLargeCar {
				DistanceAwayInKm = 3.0
			};

			var vehicles = new List<Vehicle> {car1, car2, luxuryCar1, extraLargeCar1};

			Console.WriteLine("The following vehicles are currently in your area:");
			foreach(var vehicle in vehicles)
			{
				vehicle.ReportDistance();
			}

			// 2.1. TODO: Create a list that can hold the above cars, extra large cars and luxury cars

			// 2.2. Check for nearby cars, extra large cars and luxury cars
			// by creating a foreach loop that goes through each of the cars, motorbikes and luxury cars created
			// and calls their ReportDistance method
        }

    }
}
