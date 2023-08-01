using System;
namespace FactoryPattern
{
	public class Motorcycle : iVehicle
	{
		public Motorcycle()
		{
		}

		public void Build()
		{
            Console.WriteLine("Motorcycle Building... Building... Building... Ping! Done!");
        }

	}
}

