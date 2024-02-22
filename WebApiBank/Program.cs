using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiBank.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Variable para cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("BankApiDB");
// Registrar servicio de conexion
builder.Services.AddDbContext<BankApiDB>(options => 
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddDbContext<ConfigurationContext>(options => {
//        options.UseSqlServer(Configuration.GetConnectionString("MyConnection"));
//    });
//}


var app = builder.Build();

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
