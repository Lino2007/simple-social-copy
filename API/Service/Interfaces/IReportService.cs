using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Service.Interfaces
{
    public interface IReportService : ICrudService<Report>
    {
        public Task<Report?> Update(UpdateReportRequest entity);
    }
}