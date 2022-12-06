using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Repository.Interfaces
{
    public interface IReportRepository : ICrudRepository<Report>
    {
        Task<Report?> UpdateReport(UpdateReportRequest report);
    }
}