using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string? Usuario1 { get; set; }

    public string? Clave { get; set; }

    public int? RolId { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Rol? Rol { get; set; }
}
