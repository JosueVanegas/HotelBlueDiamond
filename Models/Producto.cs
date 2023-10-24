using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? CategoriaProductoId { get; set; }

    public virtual CategoriaProducto? CategoriaProducto { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
