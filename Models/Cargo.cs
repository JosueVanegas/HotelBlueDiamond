using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Cargo
{
    public int CargoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? SalarioBasePh { get; set; }

    public decimal? Comision { get; set; }

    public decimal? Bonificacion { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
