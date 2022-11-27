using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class PersonBanRepository : CrudRepository<PersonBan>, IPersonBanRepository
    {
        public PersonBanRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}