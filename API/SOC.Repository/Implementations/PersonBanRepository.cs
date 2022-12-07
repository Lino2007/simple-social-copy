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

        public async Task<PersonBan?> UpdatePersonBan(UpdatePersonBanRequest personBan)
        {
            var p = await db.PersonBans.SingleOrDefaultAsync(t => t.Id.Equals(personBan.Id));
            if (p == null)
            {
                return null;
            }
            db.Entry(p).CurrentValues.SetValues(personBan);
            return await Update(p);
        }
    }
}