using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class RolePermissionRepository : CrudRepository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}