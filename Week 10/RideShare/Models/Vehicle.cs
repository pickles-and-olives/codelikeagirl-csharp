using System;

namespace RideShare.Models
{
public abstract class Vehicle
{
	public double DistanceAwayInKm { get; set; }

	public virtual void ReportDistance()
	{
		Console.WriteLine($"There is a vehicle {DistanceAwayInKm}km away.");
	}
}
	public class Car : Vehicle
	{
		
	}

	public class ExtraLargeCar : Vehicle
	{

	}

	public class LuxuryCar : Vehicle
	{
		public override void ReportDistance()
		{
			Console.WriteLine($"You're in for a smooth ride! There is a luxury vehicle {DistanceAwayInKm}km away.");
		}
	}
}