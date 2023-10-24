using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class RolesAcceso
{
    public int RolId { get; set; }

    public string? Descripcion { get; set; }

    public int NivelAcceso { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
