using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface IPersonService : ICrudService<Person>
    {
        public Task<Person> Update(UpdatePersonRequest entity);
    }
}