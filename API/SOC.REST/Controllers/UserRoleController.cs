using SOC.DataContracts.Models;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            this.userRoleService = userRoleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRoleResponse>>> GetUserRoles()
        {
            var userRoles = (await userRoleService.GetAll()).Select(t => (UserRoleResponse)t);
            return new ActionResult<IEnumerable<UserRoleResponse>>(userRoles);
        }
    }
}