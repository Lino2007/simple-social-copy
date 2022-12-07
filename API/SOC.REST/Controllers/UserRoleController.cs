using SOC.DataContracts.Models;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<IEnumerable<UserRole>>> GetUserRoles()
        {
            return new ActionResult<IEnumerable<UserRole>>(await userRoleService.GetAll());
        }
    }
}