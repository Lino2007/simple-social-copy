using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Service.Interfaces
{
    public interface IPersonService : ICrudService<Person>
    {
        public Task<Person?> Update(UpdatePersonRequest entity);
    }
}