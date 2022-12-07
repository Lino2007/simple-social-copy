using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface IReportService : ICrudService<Report>
    {
        public Task<Report?> Update(UpdateReportRequest entity);
    }
}