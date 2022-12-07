using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<Report?>> GetReportById(Guid id)
        {
            return await reportService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Report>>> GetReports()
        {
            return new ActionResult<IEnumerable<Report>>(await reportService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Report>> AddReport([FromBody] AddReportRequest report)
        {
            return await reportService.Add((Report)report);
        }

        [HttpPatch]
        public async Task<ActionResult<Report?>> UpdateReport([FromBody] UpdateReportRequest report)
        {
            return await reportService.Update(report);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteReport(Guid id)
        {
            await reportService.Delete(id);
            return NoContent();
        }
    }
}