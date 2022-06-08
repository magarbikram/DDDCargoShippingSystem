using CargoShipping.Domain.LocationAggregate;
using System;

namespace CargoShipping.Domain.CargoAggregate
{
    public class DeliverySpecification
    {
        public DateTimeOffset ArrivalTime { get; private set; }
        public Location DestinationLocation { get; private set; }
    }
}