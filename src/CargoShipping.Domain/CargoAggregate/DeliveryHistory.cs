using CargoShipping.Domain.HandlingEventAggregate;
using System;
using System.Collections.Generic;

namespace CargoShipping.Domain.CargoAggregate
{
    public class DeliveryHistory
    {
        public Cargo Cargo { get; private set; }
        public List<HandlingEvent> HandlingEvents { get; private set; }

        protected DeliveryHistory()
        {

        }

        public DeliveryHistory(Cargo cargo)
        {
            Cargo = cargo;
        }

        public void AddHandlingEvent(HandlingEvent handlingEvent)
        {
            HandlingEvents.Add(handlingEvent);
        }
    }
}