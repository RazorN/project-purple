using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Application.Models
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
    }
}
