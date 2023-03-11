using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using SOC.Common.Exceptions;

namespace SOC.Repository.Implementations
{
    public class PersonRepository : CrudRepository<Person>, IPersonRepository
    {
        public PersonRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async Task<Person> RegisterPerson(Person userToRegister)
        {
            var person = await db.People.Where(p => p.Nickname.Equals(userToRegister.Nickname) ||
                         p.Email.Equals(userToRegister.Email)).Select(p => new { p.Email, p.Nickname }).FirstOrDefaultAsync();

            if (person is not null)
            {
                if (person.Email.Equals(userToRegister.Email))
                {
                    throw new RegistrationException($"User with email {userToRegister.Email} already exists!");
                }
                throw new RegistrationException($"User with nickname {userToRegister.Nickname} already exists!");
            }
            return await Add(userToRegister);
        }
    }
}