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
    }
}