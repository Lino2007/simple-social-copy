using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Implementations
{
    public class PersonRepository : CrudRepository<Person>, IPersonRepository
    {
        public PersonRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async Task<Person?> UpdatePerson(UpdatePersonRequest person)
        {
            var p = await db.People.SingleOrDefaultAsync(t => t.Id.Equals(person.Id));
            if (p == null)
            {
                return null;
            }
            db.Entry(p).CurrentValues.SetValues(person);
            return await Update(p);
        }
    }
}