using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
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