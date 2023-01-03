using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService reportService;

        public ReportController(IReportService reportService)
        {
            this.reportService = reportService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReportResponse>> GetReportById(Guid id)
        {
            var report = await reportService.GetById(id);
            return report is null ? NotFound() : (ReportResponse)report;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportResponse>>> GetReports()
        {
            var reports = (await reportService.GetAll()).Select(t => (ReportResponse)t);
            return new ActionResult<IEnumerable<ReportResponse>>(reports);
        }

        [HttpPost("comment")]
        public async Task<ActionResult<ReportResponse>> AddReportToComment([FromBody] AddCommentReportRequest report)
        {
            return (ReportResponse)await reportService.Add((Report)report);
        }

        [HttpPost("post")]
        public async Task<ActionResult<ReportResponse>> AddReportToPost([FromBody] AddPostReportRequest report)
        {
            return (ReportResponse)await reportService.Add((Report)report);
        }

        [HttpPatch]
        public async Task<ActionResult<ReportResponse>> UpdateReport([FromBody] UpdateReportRequest report)
        {
            var updatedReport = await reportService.Update(report);
            return updatedReport is null ? NotFound() : (ReportResponse)updatedReport;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(Guid id)
        {
            await reportService.Delete(id);
            return NoContent();
        }
    }
}