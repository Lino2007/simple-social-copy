using SOC.DataContracts.Models;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<IEnumerable<RolePermission>>> GetRolePermissions()
        {
            return new ActionResult<IEnumerable<RolePermission>>(await rolePermissionService.GetAll());
        }
    }
}