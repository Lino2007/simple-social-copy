using SOC.DataContracts.Models;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolePermissionController : ControllerBase
    {
        private readonly IRolePermissionService rolePermissionService;

        public RolePermissionController(IRolePermissionService rolePermissionService)
        {
            this.rolePermissionService = rolePermissionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RolePermissionResponse>>> GetRolePermissions()
        {
            var rolePermissions = (await rolePermissionService.GetAll()).Select(t => (RolePermissionResponse)t);
            return new ActionResult<IEnumerable<RolePermissionResponse>>(rolePermissions);
        }
    }
}