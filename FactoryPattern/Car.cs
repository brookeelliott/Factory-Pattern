using System;
namespace FactoryPattern
{
	public class Car : iVehicle
	{
		public Car()
		{
		}

		public void Build()
		{
			Console.WriteLine("Car Building... Building... Building... Ping! Done!");
		}

	}
}

