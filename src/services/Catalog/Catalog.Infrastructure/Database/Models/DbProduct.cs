using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Catalog.Infrastructure.Database.Models.Product
{
    public class DbProduct
    {
        [Key]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
    }
}