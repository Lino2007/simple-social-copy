using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }

        public async Task<UserRole> Add(UserRole entity)
        {
            return await userRoleRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await userRoleRepository.Delete(id);
        }

        public async Task<IEnumerable<UserRole>> GetAll()
        {
            return await userRoleRepository.GetAll();
        }

        public async Task<UserRole?> GetById(Guid id)
        {
            return await userRoleRepository.GetById(id);
        }

        public async Task<UserRole> Update(UserRole entity)
        {
            return await userRoleRepository.Update(entity);
        }
    }
}