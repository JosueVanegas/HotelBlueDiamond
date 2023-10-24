using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class HistorialEmpleo
{
    public int HistorialId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? CargoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public virtual Cargo? Cargo { get; set; }

    public virtual Empleado? Empleado { get; set; }
}
