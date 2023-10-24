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

    public virtual ICollection<Limpieza> Limpiezas { get; set; } = new List<Limpieza>();

    public virtual ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual RolesAcceso? Rol { get; set; }
}
