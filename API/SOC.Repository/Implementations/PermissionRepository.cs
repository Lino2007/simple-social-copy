using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;

namespace SOC.Repository.Implementations
{
    public class PermissionRepository : ReadRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}