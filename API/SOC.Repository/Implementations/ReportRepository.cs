using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SOC.Repository.Implementations
{
    public class ReportRepository : CrudRepository<Report>, IReportRepository
    {
        public ReportRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async Task<Report?> UpdateReport(UpdateReportRequest report)
        {
            var r = await db.Reports.SingleOrDefaultAsync(t => t.Id.Equals(report.Id));
            if (r == null)
            {
                return null;
            }
            db.Entry(r).CurrentValues.SetValues(report);
            return await Update(r);
        }
    }
}