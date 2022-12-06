using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
{
    public class RolePermissionService : IRolePermissionService
    {
        private readonly IRolePermissionRepository rolePermissionRepository;

        public RolePermissionService(IRolePermissionRepository rolePermissionRepository)
        {
            this.rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<RolePermission> Add(RolePermission entity)
        {
            return await rolePermissionRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await rolePermissionRepository.Delete(id);
        }

        public async Task<IEnumerable<RolePermission>> GetAll()
        {
            return await rolePermissionRepository.GetAll();
        }

        public async Task<RolePermission?> GetById(Guid id)
        {
            return await rolePermissionRepository.GetById(id);
        }

        public async Task<RolePermission> Update(RolePermission entity)
        {
            return await rolePermissionRepository.Update(entity);
        }
    }
}