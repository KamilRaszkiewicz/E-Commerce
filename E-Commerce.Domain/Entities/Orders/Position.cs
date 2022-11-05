using E_Commerce.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Orders
{
    public class Position
    {
        public int PositionId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
