using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipping.Domain.CustomerAggregate
{
    public class Customer
    {
        public string CustomerId { get; private set; }
        protected Customer()
        {

        }
    }
}
