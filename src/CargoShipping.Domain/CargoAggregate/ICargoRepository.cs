using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipping.Domain.CargoAggregate
{
    public interface ICargoRepository
    {
        Cargo FindByCargoTrackingId(string cargoTrackingId);
        void Update(Cargo cargo);
        void SaveChanges();
    }
}
