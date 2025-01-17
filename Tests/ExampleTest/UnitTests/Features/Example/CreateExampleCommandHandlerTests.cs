using RefresherApp.Shared.Examples.DTOs;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefresherApp.Application.Examples.Features.Examples.Commands;
using RefresherApp.Application.Examples.Interfaces;
using Moq;

namespace ExampleTest.UnitTests.Features.Example
{

    public class CreateExampleCommandHandlerTests
    {
        [Fact]
        public async Task Create_ShouldBeReturn_Id()
        {
            CreateExampleCommand command = new CreateExampleCommand("test", "test@test.com");
            var repository = new Mock<IExampleRepository>();
            var handler = new CreateExampleCommandHandler(repository.Object);
            var token = new CancellationToken();
            Guid result = await handler.Handle(command, token);
            Guid guidResult;
            Assert.True(Guid.TryParse(result.ToString(), out guidResult ));
        }
    }
}
