using System.Text.Json;
using PymesRetail.Core.Entities;
using PymesRetail.Core.Services;
using StackExchange.Redis;

namespace PymesRetail.Redis.Services;

public class VentasServiceRedis : IVentasService
{
    private readonly IDatabase _db;

    public VentasServiceRedis(IDatabase db)
    {
        _db = db;
    }

    private const string ListaEventosKey = "eventos:escaneo";

    public async Task RegistrarEscaneoAsync(EventoEscaneo evento)
    {
        // Convertimos el evento a JSON simple
        var json = JsonSerializer.Serialize(evento);

        // LPUSH eventos:escaneo "json..."
        await _db.ListLeftPushAsync(ListaEventosKey, json);
    }
}
