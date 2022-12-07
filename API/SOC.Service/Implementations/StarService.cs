using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
{
    public class StarService : IStarService
    {
        private readonly IStarRepository starRepository;

        public StarService(IStarRepository starRepository)
        {
            this.starRepository = starRepository;
        }

        public async Task<Star> Add(Star entity)
        {
            return await starRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await starRepository.Delete(id);
        }

        public async Task<IEnumerable<Star>> GetAll()
        {
            return await starRepository.GetAll();
        }

        public async Task<Star?> GetById(Guid id)
        {
            return await starRepository.GetById(id);
        }

        public async Task<Star> Update(Star entity)
        {
            return await starRepository.Update(entity);
        }
    }
}