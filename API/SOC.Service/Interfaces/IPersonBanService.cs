using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface IPersonBanService : ICrudService<PersonBan>
    {
        Task<PersonBan?> Update(UpdatePersonBanRequest entity);
    }
}