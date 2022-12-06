using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
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

        public async Task<Permission?> GetById(Guid id)
        {
            return await permissionRepository.GetById(id);
        }
    }
}