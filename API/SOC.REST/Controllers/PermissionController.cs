using SOC.DataContracts.Models;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            this.permissionService = permissionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PermissionResponse>>> GetPermissions()
        {
            var permissions = (await permissionService.GetAll()).Select(t => (PermissionResponse)t);
            return new ActionResult<IEnumerable<PermissionResponse>>(permissions);
        }
    }
}