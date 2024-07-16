using Microsoft.EntityFrameworkCore;
using Trening.BLL;
using Trening.BLL.Services;
using Trening.DAL;
using Trening.DAL.Models;
using Trening.DAL.Repositories;
using Trening.Models.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var AppConfig = builder.Configuration;

IConfigurationSection configuration = AppConfig.GetSection("ConnectionStrings");
string connectionString = configuration.GetSection("Data").Value;

/*builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);
builder.Services.AddTransient(typeof(IGenericRepository<Customer>), typeof(GenericRepository<Customer>));
builder.Services.AddTransient(typeof(IGenericRepository<Product>), typeof(GenericRepository<Product>));
builder.Services.AddTransient(typeof(IGenericRepository<Transaction>), typeof(GenericRepository<Transaction>));

builder.Services.AddTransient(typeof(IGenericService<Customer>), typeof(GenericService<Customer>));
builder.Services.AddTransient(typeof(IGenericService<Product>), typeof(GenericService<Product>));
builder.Services.AddTransient(typeof(IGenericService<Transaction>), typeof(GenericService<Transaction>));
*/
builder.Services.AddTransient(typeof(IGenericRepository<IEntity>), typeof(GenericRepository<IEntity>));
builder.Services.AddTransient(typeof(IGenericService<IBusinessEntity>), typeof(GenericService<IBusinessEntity>));

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
