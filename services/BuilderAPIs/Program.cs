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
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
builder.Services.AddScoped<IComponentsRepository, ComponentsRepository>();

// Configuracion de servicios
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin() // Permitir cualquier origen
               .AllowAnyMethod() // Permitir cualquier metodo (GET, POST, etc.)
               .AllowAnyHeader(); // Permitir cualquier encabezado
    });
});

var app = builder.Build();

// Configurar el middleware

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Configure the HTTP request pipeline.
app.UseCors("AllowAllOrigins");

// Configure the HTTP request pipeline.
app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
