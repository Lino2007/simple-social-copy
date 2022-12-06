using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public async Task<Person> Add(Person entity)
        {
            return await personRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await personRepository.Delete(id);
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await personRepository.GetAll();
        }

        public async Task<Person?> GetById(Guid id)
        {
            return await personRepository.GetById(id);
        }

        public async Task<Person> Update(Person entity)
        {
            return await personRepository.Update(entity);
        }

        public async Task<Person?> Update(UpdatePersonRequest entity)
        {
            return await personRepository.UpdatePerson(entity);
        }
    }
}