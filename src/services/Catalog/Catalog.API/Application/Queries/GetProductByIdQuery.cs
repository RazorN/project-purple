using Catalog.API.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Application.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        [FromRoute(Name = "id")]
        public Guid ProductId { get; set; }
    }
}
