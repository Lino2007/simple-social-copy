using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class UserRoleRepository : CrudRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}