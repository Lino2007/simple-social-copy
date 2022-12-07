using SOC.DataContracts.Models;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<IEnumerable<Permission>>> GetPermissions()
        {
            return new ActionResult<IEnumerable<Permission>>(await permissionService.GetAll());
        }
    }
}