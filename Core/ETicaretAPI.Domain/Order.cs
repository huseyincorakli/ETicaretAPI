using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain
{
    public class Order: BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; } //Value Object
        public ICollection<Product> Products{ get; set; }
        public Customer Customer{ get; set; }
        public int CustomerId { get; set; }
    }
}
