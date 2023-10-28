using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Rol
{
    public int RolId { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? NivelAcceso { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
