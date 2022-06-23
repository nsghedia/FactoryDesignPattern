using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Boat : Vehicle
    {
        public Boat()
        {
            base.capacity = 150;
        }
        public override string GetData()
        {
            return "I am a boat!";
        }
    }
    class Bus : Vehicle
    {
        public Bus()
        {
            base.capacity = 50;
        }
        public override string GetData()
        {
            return "I am a Bus!";
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            base.capacity = 5;
        }
        public override string GetData()
        {
            return "I am a car!";
        }
    }
}
