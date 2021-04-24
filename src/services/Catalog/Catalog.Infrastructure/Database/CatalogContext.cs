using Catalog.Infrastructure.Database.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.Database
{
    public class CatalogContext : DbContext
    {
        public DbSet<DbProduct> Products { get; set; }
        public CatalogContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
