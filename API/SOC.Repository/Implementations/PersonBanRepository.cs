using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SOC.Repository.Implementations
{
    public class PersonBanRepository : CrudRepository<PersonBan>, IPersonBanRepository
    {
        public PersonBanRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}