using System.Threading.Tasks;
using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Repository.Interfaces
{
    public interface IPersonRepository : ICrudRepository<Person>
    {
        public Task<Person?> UpdatePerson(UpdatePersonRequest post);
    }
}