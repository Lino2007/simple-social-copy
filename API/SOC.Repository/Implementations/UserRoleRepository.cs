using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;

namespace SOC.Repository.Implementations
{
    public class UserRoleRepository : CrudRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}