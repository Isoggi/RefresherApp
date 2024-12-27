using System;
using System.Collections.Generic;

namespace RefresherApp.Application.Examples.Interfaces
{
    public interface IExampleRepository
    {
        Task<ICollection<Domain.Entities.Examples>> GetAll();

        Task<Domain.Entities.Examples> GetExampleById(int personId);

        Task<Domain.Entities.Examples> AddExample(Domain.Entities.Examples toCreate);

        Task<Domain.Entities.Examples> UpdatePerson(int personId, string name, string email);

        Task DeletePerson(int personId);
    }
}
