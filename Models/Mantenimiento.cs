using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Mantenimiento
{
    public int MantenimientoId { get; set; }

    public int? HabitacionId { get; set; }

    public int? EmpleadoId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public decimal? ComisionGenerada { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Habitacion? Habitacion { get; set; }
}
