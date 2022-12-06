using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Repository.Interfaces
{
    public interface IPersonRepository : ICrudRepository<Person>
    {
        public Task<Person?> UpdatePerson(UpdatePersonRequest post);
    }
}