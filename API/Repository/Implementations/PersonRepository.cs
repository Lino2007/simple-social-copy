using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class PersonRepository : CrudRepository<Person>, IPersonRepository
    {
        public PersonRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}