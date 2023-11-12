using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class CategoriaProducto
{
    public int CategoriaProductoId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
