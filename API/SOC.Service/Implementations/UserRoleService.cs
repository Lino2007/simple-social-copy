using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
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

        public async Task<UserRole> GetById(Guid id)
        {
            return await userRoleRepository.GetById(id);
        }

        public async Task<UserRole> Update(UserRole entity)
        {
            return await userRoleRepository.Update(entity);
        }
    }
}