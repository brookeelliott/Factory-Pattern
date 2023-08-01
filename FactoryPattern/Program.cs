namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            int userInputInt;
            bool userInput = false;

            do
            {
                Console.WriteLine("Hello, how many wheels do you want?");
                userInput = int.TryParse(Console.ReadLine(), out userInputInt);
                
            } while (userInput == false);

            var vehicle = VehicleFactory.GetVehicle(userInputInt);
            vehicle.Build();
        }
    }
}
