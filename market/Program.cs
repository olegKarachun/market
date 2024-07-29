using market.Mapper;
using Market.BLL.Service;
using Market.DAL;
using Market.DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperProfile));

var AppConfig = builder.Configuration;
IConfigurationSection configuration = AppConfig.GetSection("ConnectionStrings");
string connectionString = configuration.GetSection("Data").Value;

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

// Register repository and service
builder.Services.AddTransient<CustomerRepository>();
builder.Services.AddTransient<CustomerService>();
builder.Services.AddTransient<ProductRepository>();
builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<TransactionRepository>();
builder.Services.AddTransient<TransactionService>();

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
