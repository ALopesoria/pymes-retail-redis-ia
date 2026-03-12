using PymesRetail.Core.Entities;

namespace PymesRetail.Core.Services;

public interface IVentasService
{
    Task RegistrarEscaneoAsync(EventoEscaneo evento);
}
