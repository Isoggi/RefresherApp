using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefresherApp.

namespace RefresherApp.Application.Examples.Interfaces
{
    public interface IExampleRepository
    {
        Task<ICollection<Examples>> GetAll();

        Task<Person> GetPersonById(int personId);

        Task<Person> AddPerson(Person toCreate);

        Task<Person> UpdatePerson(int personId, string name, string email);

        Task DeletePerson(int personId);
    }
}
