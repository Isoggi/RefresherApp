﻿using RefresherApp.Domain.Entities;
using RefresherApp.Application.Examples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherApp.Infrastructure.Repositories
{
    internal class ExamplesRepository : IExampleRepository
    {
        
        public async Task<Examples> AddExample(Examples toCreate)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteExample(int personId)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Examples>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Examples> GetExampleById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Examples> UpdateExample(int exampleId, string name, string email)
        {
            throw new NotImplementedException();
        }
    }
}
