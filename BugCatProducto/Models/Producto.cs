﻿namespace BugCatProducto.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string? nombre { get; set; }
        public string? categoria { get; set; }
        public string? descripcion { get; set; }
        public int stock  { get; set; }
        public double precio { get; set; }
        public string? estado{ get; set; }

    }
}
