using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class VehicleCreator
    {
        protected abstract Vehicle MakeVehicle();
        public Vehicle CreateVehicle()
        {
            return this.MakeVehicle();
        }
        public static Vehicle GetVehicle(int passengers)
        {
            if (passengers <= 5)
                return new Car();
            else if (passengers > 5 && passengers <= 50)
                return new Bus();
            else
                return new Boat();
        }
    }
}
