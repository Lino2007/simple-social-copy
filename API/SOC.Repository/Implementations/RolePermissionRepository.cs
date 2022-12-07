using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;

namespace SOC.Repository.Implementations
{
    public class RolePermissionRepository : CrudRepository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}