using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? CategoriaProductoId { get; set; }

    public int? Stock { get; set; }

    public int? ProveedorId { get; set; }

    public virtual CategoriaProducto? CategoriaProducto { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual ICollection<MovimientoProducto> MovimientoProductos { get; set; } = new List<MovimientoProducto>();

    public virtual Proveedor? Proveedor { get; set; }
}
