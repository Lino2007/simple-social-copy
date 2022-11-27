using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class RoleRepository : CrudRepository<Role>, IRoleRepository
    {
        public RoleRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}