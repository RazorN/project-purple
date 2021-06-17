using Catalog.API.Application.Commands;
using Catalog.API.Application.Models;
using Catalog.API.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]CreateProductCommand command)
        {
            var product = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            return await _mediator.Send(new GetAllProductsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> GetProductById([FromRoute]GetProductByIdQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}