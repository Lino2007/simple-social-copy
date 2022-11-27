using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class ReportRepository : CrudRepository<Report>, IReportRepository
    {
        public ReportRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}