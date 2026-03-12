using PymesRetail.Core.Entities;
using StackExchange.Redis;

namespace PymesRetail.Redis.Repositories;

public class ProductoRepository
{
    private readonly IDatabase _db;

    public ProductoRepository(IDatabase db)
    {
        _db = db;
    }

    private static string GetKey(string gtin) => $"producto:{gtin}";

    public async Task<Producto?> GetProductoPorGtinAsync(string gtin)
    {
        var key = GetKey(gtin);
        var hash = await _db.HashGetAllAsync(key);

        if (hash.Length == 0)
        {
            return null;
        }

        // Helpers para extraer campos
        string GetString(string field) =>
            hash.FirstOrDefault(x => x.Name == field).Value.HasValue
                ? hash.First(x => x.Name == field).Value.ToString()
                : string.Empty;

        decimal GetDecimal(string field)
        {
            var entry = hash.FirstOrDefault(x => x.Name == field);
            if (!entry.Value.HasValue) return 0m;
            if (decimal.TryParse(entry.Value.ToString(), out var value))
                return value;
            return 0m;
        }

        return new Producto
        {
            Gtin        = gtin,
            Descripcion = GetString("descripcion"),
            Categoria   = GetString("categoria"),
            Precio      = GetDecimal("precio"),
            Iva         = GetDecimal("iva")
        };
    }

    public async Task GuardarProductoAsync(Producto p)
    {
        var key = GetKey(p.Gtin);

        var entries = new HashEntry[]
        {
            new("descripcion", p.Descripcion),
            new("categoria",   p.Categoria),
            new("precio",      p.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture)),
            new("iva",         p.Iva.ToString(System.Globalization.CultureInfo.InvariantCulture))
        };

        await _db.HashSetAsync(key, entries);
    }
}
