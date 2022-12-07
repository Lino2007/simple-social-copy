using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface IPersonBanService : ICrudService<PersonBan>
    {
        public Task<PersonBan?> Update(UpdatePersonBanRequest entity);
    }
}