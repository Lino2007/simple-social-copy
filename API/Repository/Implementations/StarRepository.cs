using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class StarRepository : CrudRepository<Star>, IStarRepository
    {
        public StarRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}