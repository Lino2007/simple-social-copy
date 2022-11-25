using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using API.Models;
using System.Linq;
using System;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeneralController : ControllerBase
{
    private readonly ILogger<GeneralController> _logger;
    private readonly SimpleSocialContext _db;

    public GeneralController(ILogger<GeneralController> logger, SimpleSocialContext db)
    {
        _logger = logger;
        _db = db;
    }

    [HttpGet("category")]
    public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
    {
        return await _db.Categories.AsNoTracking().ToListAsync();
    }

    [HttpGet("person")]
    public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
    {
        return await _db.People.AsNoTracking().ToListAsync();
    }

    [HttpGet("comment")]
    public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
    {
        return await _db.Comments.AsNoTracking().ToListAsync();
    }

    [HttpGet("permission")]
    public async Task<ActionResult<IEnumerable<Permission>>> GetPermissions()
    {
        return await _db.Permissions.AsNoTracking().ToListAsync();
    }

    [HttpGet("personban")]
    public async Task<ActionResult<IEnumerable<PersonBan>>> GetPersonBans()
    {
        return await _db.PersonBans.AsNoTracking().ToListAsync();
    }

    [HttpGet("post")]
    public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
    {
        return await _db.Posts.AsNoTracking().ToListAsync();
    }

    [HttpGet("report")]
    public async Task<ActionResult<IEnumerable<Report>>> GetReports()
    {
        return await _db.Reports.AsNoTracking().ToListAsync();
    }

    [HttpGet("role")]
    public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
    {
        return await _db.Roles.AsNoTracking().ToListAsync();
    }

    [HttpGet("rolepermission")]
    public async Task<ActionResult<IEnumerable<RolePermission>>> GetRolePermissions()
    {
        return await _db.RolePermissions.AsNoTracking().ToListAsync();
    }

    [HttpGet("star")]
    public async Task<ActionResult<IEnumerable<Star>>> GetStars()
    {
        return await _db.Stars.AsNoTracking().ToListAsync();
    }

    [HttpGet("userrole")]
    public async Task<ActionResult<IEnumerable<UserRole>>> GetUserRoles()
    {
        return await _db.UserRoles.AsNoTracking().ToListAsync();
    }
}