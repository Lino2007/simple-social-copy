using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public async Task<Role> Add(Role entity)
        {
            return await roleRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await roleRepository.Delete(id);
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            return await roleRepository.GetAll();
        }

        public async Task<Role?> GetById(Guid id)
        {
            return await roleRepository.GetById(id);
        }

        public async Task<Role> Update(Role entity)
        {
            return await roleRepository.Update(entity);
        }
    }
}