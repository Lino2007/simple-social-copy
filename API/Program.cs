using System.Linq;
using System.Reflection;
using API;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// register repositories
Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.EndsWith("Repository") && !t.IsAbstract && !t.IsInterface)
    .Select(a => new { assignedType = a, serviceTypes = a.GetInterfaces().ToList() })
    .ToList()
    .ForEach(typesToRegister =>
    {
        typesToRegister.serviceTypes.ForEach(typeToRegister => builder.Services.AddScoped(typeToRegister, typesToRegister.assignedType));
    });

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


