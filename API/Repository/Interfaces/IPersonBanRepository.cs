using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Repository.Interfaces
{
    public interface IPersonBanRepository : ICrudRepository<PersonBan>
    {
        Task<PersonBan?> UpdatePersonBan(UpdatePersonBanRequest personBan);
    }
}