using MediatR;
using RefresherApp.Shared.Examples.DTOs;

namespace RefresherApp.Application.Examples.Features.Examples.Queries
{
    public class GetExampleByIdQuery : IRequest<ExampleDto>
    {
        public Guid Id { get; set; }
    }
}
