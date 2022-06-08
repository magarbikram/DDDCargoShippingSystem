using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipping.Domain.CargoAggregate.Factories
{
    public class CargoFactory
    {
        public Cargo NewCargo(Cargo prototype, string newTrackingId)
        {
            throw new NotImplementedException();
        }

        public Cargo NewCargo(Cargo protoType)
        {
            //CargoFactory to use service to create new TrackingId itself for encapsulating the process of generating TrackingId
            throw new NotImplementedException();
        }
    }
}
