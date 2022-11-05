using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Products
{
    [NotMapped]
    public class Detail
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
