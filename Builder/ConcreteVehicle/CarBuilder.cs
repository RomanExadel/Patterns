using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteVehicle
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            _vehicle = new Vehicle("Car");
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "1000";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "4";
        }
    }
}
