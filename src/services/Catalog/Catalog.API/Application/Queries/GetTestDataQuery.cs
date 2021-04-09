using Catalog.API.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Application.Queries
{
    public class GetTestDataQuery : IRequest<TestDataDto>
    {
        public string userName;
    }
}
