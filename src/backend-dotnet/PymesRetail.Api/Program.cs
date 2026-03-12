using PymesRetail.Core.Services;
using PymesRetail.Redis;
using PymesRetail.Redis.Repositories;
using PymesRetail.Redis.Services;

var builder = WebApplication.CreateBuilder(args);

// Redis
builder.Services.AddSingleton<RedisConnectionProvider>();
builder.Services.AddSingleton(sp =>
{
    var provider = sp.GetRequiredService<RedisConnectionProvider>();
    return provider.GetDatabase();
});

// Repositorios y servicios de dominio
builder.Services.AddSingleton<ProductoRepository>();
builder.Services.AddSingleton<IVentasService, VentasServiceRedis>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
