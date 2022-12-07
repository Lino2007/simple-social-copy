using Microsoft.EntityFrameworkCore;
using SOC.Repository;
using SOC.Repository.Implementations;
using SOC.Repository.Interfaces;
using SOC.Service.Implementations;
using SOC.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// register repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IPermissionRepository, PermissionRepository>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPersonBanRepository, PersonBanRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IReportRepository, ReportRepository>();
builder.Services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IStarRepository, StarRepository>();
builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IPermissionService, PermissionService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPersonBanService, PersonBanService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IRolePermissionService, RolePermissionService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IStarService, StarService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();


builder.Services.AddControllers();
builder.Services.AddDbContext<SimpleSocialContext>(opt => opt.UseSqlServer(builder.Configuration["ConnectionStrings:SimpleSocial"]));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseCors(builder => builder
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
    .WithOrigins("https://localhost:4200", "http://localhost:4200"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


