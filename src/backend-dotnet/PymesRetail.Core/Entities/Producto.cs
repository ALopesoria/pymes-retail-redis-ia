     namespace PymesRetail.Core.Entities;

     public class Producto
     {
         public string Gtin { get; set; } = string.Empty;
         public string Descripcion { get; set; } = string.Empty;
         public string Categoria { get; set; } = string.Empty;
         public decimal Precio { get; set; }
         public decimal Iva { get; set; }
     }
