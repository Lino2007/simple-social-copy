using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
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