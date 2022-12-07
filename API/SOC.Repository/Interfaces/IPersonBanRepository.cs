using System.Threading.Tasks;
using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Repository.Interfaces
{
    public interface IPersonBanRepository : ICrudRepository<PersonBan>
    {
        Task<PersonBan?> UpdatePersonBan(UpdatePersonBanRequest personBan);
    }
}