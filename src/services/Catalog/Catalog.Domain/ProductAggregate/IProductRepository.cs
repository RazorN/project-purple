using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.ProductAggregate
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);

        public IEnumerable<Product> GetAllProducts();

        public Product GetProductById(Guid productId);
    }
}
