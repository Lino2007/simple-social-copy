using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SOC.Repository.Implementations
{
    public class PersonRepository : CrudRepository<Person>, IPersonRepository
    {
        public PersonRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}