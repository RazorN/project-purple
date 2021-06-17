using Catalog.API.Application.Models;
using Catalog.Domain.ProductAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.API.Application.Commands.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(Guid.NewGuid(), request.Name);
            _repository.AddProduct(product);

            return new ProductDto() { ProductId = product.ProductId, Name = product.Name };
        }
    }
}
