using System;
using System.Collections.Generic;

namespace Hotel.Models;

public partial class Proveedor
{
    public int ProveedorId { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? NombreContacto { get; set; }

    public string? CargoContacto { get; set; }

    public string? Direcccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Pais { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
