using System;
using System.Collections.Generic;

namespace RefresherApp.Application.Examples.Interfaces
{
    public interface IExampleRepository
    {
        Task<ICollection<Domain.Entities.Examples>> GetAll();

        Task<Domain.Entities.Examples> GetExampleById(Guid exampleId);

        Task<Domain.Entities.Examples> AddExample(Domain.Entities.Examples toCreate);

        Task<Domain.Entities.Examples> UpdateExample(int exampleId, string name, string email);

        Task DeleteExample(int exampleId);
    }
}
