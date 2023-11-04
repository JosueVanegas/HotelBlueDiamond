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

    public DateTime? FechaRegistro { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Asignacion> Asignacions { get; set; } = new List<Asignacion>();

    public virtual Cargo? Cargo { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
