using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static iVehicle GetVehicle(int i)
		{
			if(i == 4)
			{
				return new Car();
			}
			else if (i == 2) 
			{
				return new Motorcycle();
			}
			else
			{
				return new Car();
			}
               



        }



	}
}

