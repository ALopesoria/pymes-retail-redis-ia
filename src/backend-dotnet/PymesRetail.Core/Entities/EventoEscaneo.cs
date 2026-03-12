     namespace PymesRetail.Core.Entities;

     public class EventoEscaneo
     {
         public DateTime FechaHora { get; set; }
         public string SucursalId { get; set; } = string.Empty;
         public string CajaId { get; set; } = string.Empty;
         public string Gtin { get; set; } = string.Empty;
         public int Cantidad { get; set; }
         public string Usuario { get; set; } = string.Empty;
     }
