using CargoShipping.Domain.LocationAggregate;

namespace CargoShipping.Domain.CarrierMovementAggregate
{
    public class CarrierMovement
    {
        public string ScheduleId { get; private set; }
        public Location FromLocation { get; private set; }
        public Location ToLocation { get; private set; }
        protected CarrierMovement()
        {

        }
    }
}