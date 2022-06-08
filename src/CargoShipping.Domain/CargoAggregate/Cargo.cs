using CargoShipping.Domain.CustomerAggregate;
using System;
using System.Collections.Generic;

namespace CargoShipping.Domain.CargoAggregate
{
    public class Cargo
    {
        public string TrackingId { get; private set; }
        public DeliverySpecification Goal { get; private set; }
        public DeliveryHistory DeliveryHistory { get; private set; }

        //role, customerId map
        //shipper => customer1
        //receiver => customer2
        public IDictionary<string, Customer> CustomerRoles { get; private set; }

        protected Cargo()
        {

        }

        public Cargo(string trackingId)
        {
            TrackingId = trackingId;
            DeliveryHistory = new DeliveryHistory(this);
            CustomerRoles = new Dictionary<string, Customer>();
        }

        public Cargo CopyPrototype(string newTrackingId)
        {
            throw new NotImplementedException();
        }
    }
}
