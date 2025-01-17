using MediatR;
using RefresherApp.Application.Examples.Interfaces;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo(“RefresherApp.Test”)]
namespace RefresherApp.Application.Examples.Features.Examples.Commands
{
    public sealed class CreateExampleCommandHandler : IRequestHandler<CreateExampleCommand,Guid>
    {
        private readonly IExampleRepository _exampleRepository;

        public CreateExampleCommandHandler(IExampleRepository exampleRepository) { 
            _exampleRepository = exampleRepository;
        }
        public async Task<Guid> Handle(CreateExampleCommand command, CancellationToken cancellationToken)
        {
            var example = new Domain.Entities.Examples
            {
                Id =Guid.NewGuid(),
                Name = command.Name,
                Email = command.Email,
            };

            await _exampleRepository.AddExample(example);
            return example.Id;
        }
    }
}
