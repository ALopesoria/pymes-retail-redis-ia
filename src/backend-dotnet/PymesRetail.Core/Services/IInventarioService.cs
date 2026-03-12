namespace PymesRetail.Core.Services;

public interface IInventarioService
{
    Task<int> ObtenerStockAsync(string gtin, string sucursalId);
    Task AjustarStockAsync(string gtin, string sucursalId, int delta);
}

