using Catalog.Domain.ProductAggregate;
using Catalog.Infrastructure.Database;
using Catalog.Infrastructure.Database.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogContext _context;

        public ProductRepository(CatalogContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            var dbProduct = new DbProduct()
            {
                ProductId = product.ProductId,
                Name = product.Name
            };

            _context.Products.Add(dbProduct);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var dbProducts = _context.Products.AsQueryable();

            return dbProducts.Select(x => new Product(x.ProductId, x.Name)).ToList();
        }

        public Product GetProductById(Guid productId)
        {
            var dbProduct = _context.Products.SingleOrDefault(x => x.ProductId == productId);
            return dbProduct is null ? null : new Product(dbProduct.ProductId, dbProduct.Name);
        }
    }
}
