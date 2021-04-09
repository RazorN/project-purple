using Catalog.API.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.API.Application.Queries.Handlers
{
    public class GetTestDataHandler : IRequestHandler<GetTestDataQuery, TestDataDto>
    {
        public async Task<TestDataDto> Handle(GetTestDataQuery request, CancellationToken cancellationToken)
        {
            return new TestDataDto() { testMessage = "Hello " + request.userName };
        }
    }
}
