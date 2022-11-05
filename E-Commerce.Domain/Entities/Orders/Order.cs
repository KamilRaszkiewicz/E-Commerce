using E_Commerce.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual ApplicationUser Owner { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
