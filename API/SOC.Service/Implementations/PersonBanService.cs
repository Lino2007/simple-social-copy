using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
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

        public async Task<PersonBan> GetById(Guid id)
        {
            return await personBanRepository.GetById(id);
        }

        public async Task<PersonBan> Update(PersonBan entity)
        {
            return await personBanRepository.Update(entity);
        }

        public async Task<PersonBan> Update(UpdatePersonBanRequest entity)
        {
            return await personBanRepository.Update(entity);
        }
    }
}