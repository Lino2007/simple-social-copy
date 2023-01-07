using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            this.permissionRepository = permissionRepository;
        }

        public async Task<IEnumerable<Permission>> GetAll()
        {
            return await permissionRepository.GetAll();
        }

        public async Task<Permission> GetById(Guid id)
        {
            return await permissionRepository.GetById(id);
        }
    }
}