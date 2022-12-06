using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Service.Interfaces
{
    public interface IPersonBanService : ICrudService<PersonBan>
    {
        public Task<PersonBan?> Update(UpdatePersonBanRequest entity);
    }
}