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
    public class PersonBanService : IPersonBanService
    {
        private readonly IPersonBanRepository personBanRepository;

        public PersonBanService(IPersonBanRepository personBanRepository)
        {
            this.personBanRepository = personBanRepository;
        }

        public async Task<PersonBan> Add(PersonBan entity)
        {
            return await personBanRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await personBanRepository.Delete(id);
        }

        public Task<IEnumerable<PersonBan>> GetAll()
        {
            return personBanRepository.GetAll();
        }

        public async Task<PersonBan?> GetById(Guid id)
        {
            return await personBanRepository.GetById(id);
        }

        public async Task<PersonBan> Update(PersonBan entity)
        {
            return await personBanRepository.Update(entity);
        }

        public async Task<PersonBan?> Update(UpdatePersonBanRequest entity)
        {
            return await personBanRepository.UpdatePersonBan(entity);
        }
    }
}