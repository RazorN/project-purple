using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.ProductAggregate
{
    public class Product : IAggregateRoot
    {
        public Guid ProductId { get; private set; }
        public string Name { get; set; }

        public Product(Guid id, string name)
        {
            ProductId = id;
            Name = name;
        }
    }
}
