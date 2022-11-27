using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class PermissionRepository : ReadRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}