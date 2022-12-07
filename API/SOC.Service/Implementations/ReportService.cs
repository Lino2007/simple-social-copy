using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using SOC.Service.Interfaces;

namespace SOC.Service.Implementations
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        public async Task<Report> Add(Report entity)
        {
            return await reportRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await reportRepository.Delete(id);
        }

        public async Task<IEnumerable<Report>> GetAll()
        {
            return await reportRepository.GetAll();
        }

        public async Task<Report?> GetById(Guid id)
        {
            return await reportRepository.GetById(id);
        }

        public async Task<Report> Update(Report entity)
        {
            return await reportRepository.Update(entity);
        }

        public async Task<Report?> Update(UpdateReportRequest entity)
        {
            return await reportRepository.UpdateReport(entity);
        }
    }
}