using BuilderAPIs.Domain.Interfaces;
using BuilderAPIs.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar servicios
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("ConexionDB"),
        new MySqlServerVersion(new Version(8, 0, 39)));
});

// Registrar MediatR
builder.Services.AddMediatR(typeof(Program)); // O especifica el ensamblado si es necesario

builder.Services.AddScoped<IItemsRepository, ItemsRepository>();

var app = builder.Build();

// Configurar el middleware
app.UseAuthorization();
app.MapControllers();
app.Run();
