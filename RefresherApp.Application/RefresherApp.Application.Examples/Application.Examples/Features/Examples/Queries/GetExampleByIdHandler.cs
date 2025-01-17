using MediatR;
using RefresherApp.Application.Examples.Interfaces;
using RefresherApp.Shared.Examples.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherApp.Application.Examples.Features.Examples.Queries
{
    internal class GetExampleByIdHandler : IRequestHandler<GetExampleByIdQuery, ExampleDto>
    {
        private readonly IExampleRepository _repository;

        public GetExampleByIdHandler(IExampleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExampleDto> Handle(GetExampleByIdQuery request, CancellationToken cancellationToken)
        {
            var example = await _repository.GetExampleById(request.Id);
            return new ExampleDto
            {
                Id = example.Id,
                Name = example.Name,
                Email = example.Email
            };
        }
    }
}
