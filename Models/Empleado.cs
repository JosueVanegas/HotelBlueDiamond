using System;
using System.Collections.Generic;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateTime? Nacimiento { get; set; }

    public int? CargoId { get; set; }

    public int? RolId { get; set; }

    public virtual Cargo? Cargo { get; set; }

    public virtual ICollection<HistorialEmpleo> HistorialEmpleos { get; set; } = new List<HistorialEmpleo>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual RolesAcceso? Rol { get; set; }

    public virtual ICollection<TipoAsignacion> TipoAsignacions { get; set; } = new List<TipoAsignacion>();
}
