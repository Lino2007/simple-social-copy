using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;

namespace SOC.Repository.Implementations
{
    public class StarRepository : CrudRepository<Star>, IStarRepository
    {
        public StarRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}