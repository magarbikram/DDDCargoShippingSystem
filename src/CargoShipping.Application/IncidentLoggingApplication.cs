using CargoShipping.Domain.CargoAggregate;
using CargoShipping.Domain.HandlingEventAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipping.Application
{
    public class IncidentLoggingApplication
    {
        private readonly ICargoRepository _cargoRepository;

        public IncidentLoggingApplication(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }
        public void AddHandlingEventForCargo(string cargoTrackingId)
        {
            Cargo cargo = _cargoRepository.FindByCargoTrackingId(cargoTrackingId);
            HandlingEvent handlingEvent = new HandlingEvent(cargo, HandlingEventType.Loading, DateTimeOffset.Now);
            cargo.DeliveryHistory.AddHandlingEvent(handlingEvent);

            _cargoRepository.Update(cargo);
            _cargoRepository.SaveChanges();//this might faile because of contentiion for a cargo or its component delivery history
        }
    }
}
