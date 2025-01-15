using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherApp.Application.Examples.Features.Examples.Commands
{
    public class CreateExampleCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public string Email { get; set; }
    }
}
