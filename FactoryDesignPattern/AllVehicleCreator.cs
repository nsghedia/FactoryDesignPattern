using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class BoatCreator : VehicleCreator
    {
        protected override Vehicle MakeVehicle()
        {
            Vehicle vehicle = new Boat();
            vehicle.capacity = 150;
            return vehicle;
        }
    }
    public class CarCreator : VehicleCreator
    {
        protected override Vehicle MakeVehicle()
        {
            Vehicle vehicle = new Car();
            vehicle.capacity = 5;
            return vehicle;
        }
    }
    public class BusCreator : VehicleCreator
    {
        protected override Vehicle MakeVehicle()
        {
            Vehicle vehicle = new Bus();
            vehicle.capacity = 50;
            return vehicle;
        }
    }
}
