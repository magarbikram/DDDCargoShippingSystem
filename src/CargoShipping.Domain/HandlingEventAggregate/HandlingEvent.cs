using CargoShipping.Domain.CargoAggregate;
using CargoShipping.Domain.CarrierMovementAggregate;
using System;

namespace CargoShipping.Domain.HandlingEventAggregate
{
    public class HandlingEvent
    {
        public Cargo Handled { get; private set; }
        public HandlingEventType Type { get; private set; }
        public DateTimeOffset CompletionTime { get; private set; }

        public CarrierMovement CarrierMovement { get; private set; }

        protected HandlingEvent()
        {

        }

        public HandlingEvent(Cargo cargo, HandlingEventType eventType, DateTimeOffset completionTime)
        {
            Handled = cargo;
            Type = eventType;
            CompletionTime = completionTime;
        }

        public static HandlingEvent NewLoading(Cargo cargo, CarrierMovement loadedOnto, DateTime completionTime)
        {
            HandlingEvent handlingEvent = new HandlingEvent(cargo, HandlingEventType.Loading, completionTime);
            handlingEvent.SetCarrierMovement(loadedOnto);
            return handlingEvent;
        }

        private void SetCarrierMovement(CarrierMovement loadedOnto)
        {
            CarrierMovement = loadedOnto;
        }
    }
}