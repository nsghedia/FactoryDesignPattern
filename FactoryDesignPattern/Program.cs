using FactoryDesignPattern;

Vehicle? vehicle;
VehicleType vehicleType;

Console.WriteLine("Hello! Which transport type would you prefer? We offer travels by Bus, Car and Boat.");
var userInput = Console.ReadLine();

if (Enum.TryParse(userInput, true, out vehicleType))
{
    switch (vehicleType)
    {
        case VehicleType.Boat:
            vehicle = new BoatCreator().CreateVehicle();
            break;
        case VehicleType.Bus:
            vehicle = new BusCreator().CreateVehicle();
            break;
        case VehicleType.Car:
            vehicle = new CarCreator().CreateVehicle();
            break;
        default:
            vehicle = null;
            break;
    }
    Console.WriteLine(vehicle.GetData());
    Console.WriteLine("Vehicle capacity: " + vehicle.GetCapacity());
   
}
else
{
    Console.WriteLine("Vehicle not found, try again.");
}

Console.WriteLine("\n\n Hello. How many passengers do you need?");
int passengers = Convert.ToInt32(Console.ReadLine());
vehicle = VehicleCreator.GetVehicle(passengers);
vehicle.AddPassengers(passengers);
Console.WriteLine("Vehicle Type: " + vehicle.GetData() + ". With left capacity of: " + vehicle.GetCapacity());

public enum VehicleType
{
    Bus,
    Car,
    Boat
}