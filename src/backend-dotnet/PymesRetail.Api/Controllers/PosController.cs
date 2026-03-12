using Microsoft.AspNetCore.Mvc;
using PymesRetail.Core.Entities;
using PymesRetail.Core.Services;

namespace PymesRetail.Api.Controllers;

[ApiController]
[Route("api/pos")]
public class PosController : ControllerBase
{
    private readonly IVentasService _ventasService;

    public PosController(IVentasService ventasService)
    {
        _ventasService = ventasService;
    }

    public class EscaneoRequest
    {
        public string SucursalId { get; set; } = string.Empty;
        public string CajaId { get; set; } = string.Empty;
        public string Gtin { get; set; } = string.Empty;
        public int Cantidad { get; set; } = 1;
        public string Usuario { get; set; } = string.Empty;
    }

    [HttpPost("escaneo")]
    public async Task<IActionResult> RegistrarEscaneo([FromBody] EscaneoRequest request)
    {
        var evento = new EventoEscaneo
        {
            FechaHora = DateTime.UtcNow,
            SucursalId = request.SucursalId,
            CajaId = request.CajaId,
            Gtin = request.Gtin,
            Cantidad = request.Cantidad,
            Usuario = request.Usuario
        };

        await _ventasService.RegistrarEscaneoAsync(evento);

        return Ok(new { status = "ok" });
    }
}
