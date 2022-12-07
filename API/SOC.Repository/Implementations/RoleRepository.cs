using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;

namespace SOC.Repository.Implementations
{
    public class RoleRepository : CrudRepository<Role>, IRoleRepository
    {
        public RoleRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}