using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Dorado_DesktopApp.Models;

public partial class HotelDoradoContext : DbContext
{
    public HotelDoradoContext()
    {
    }

    public HotelDoradoContext(DbContextOptions<HotelDoradoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CategoriaHabitacion> CategoriaHabitacions { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EstadoHabitacion> EstadoHabitacions { get; set; }

    public virtual DbSet<Habitacion> Habitacions { get; set; }

    public virtual DbSet<HistorialEmpleo> HistorialEmpleos { get; set; }

    public virtual DbSet<HistorialEstadoHabitacion> HistorialEstadoHabitacions { get; set; }

    public virtual DbSet<Limpieza> Limpiezas { get; set; }

    public virtual DbSet<Mantenimiento> Mantenimientos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Piso> Pisos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<RolesAcceso> RolesAccesos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-L5B7AIOU\\SQLEXPRESS;Initial Catalog=HotelDorado;Integrated Security=true;Trust Server Certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.CargoId).HasName("PK__Cargo__B4E665ED939BA4F3");

            entity.ToTable("Cargo", "RecursosHumanos");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Bonificacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Comision)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.SalarioBasePh)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SalarioBasePH");
        });

        modelBuilder.Entity<CategoriaHabitacion>(entity =>
        {
            entity.HasKey(e => e.CategoriaHabitacionId).HasName("PK__Categori__52EEE3CD03998840");

            entity.ToTable("CategoriaHabitacion", "Habitaciones");

            entity.Property(e => e.CategoriaHabitacionId).HasColumnName("CategoriaHabitacionID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.TarifaPorHora).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.CategoriaProductoId).HasName("PK__Categori__7C808EDCC60AFB58");

            entity.ToTable("CategoriaProducto", "Servicios");

            entity.Property(e => e.CategoriaProductoId).HasColumnName("CategoriaProductoID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Cliente__71ABD0A7BE9B69C8");

            entity.ToTable("Cliente", "Reservas");

            entity.HasIndex(e => e.Email, "UQ__Cliente__A9D105342AA4418A").IsUnique();

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => new { e.PedidoId, e.ProductoId }).HasName("PK__DetalleP__23F91EF8D91A1D5E");

            entity.ToTable("DetallePedido", "Servicios");

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Estado).HasDefaultValueSql("((0))");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Pedido).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetallePe__Pedid__68487DD7");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetallePe__Produ__693CA210");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__958BE6F0C0D9D8A9");

            entity.ToTable("Empleado", "RecursosHumanos");

            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Cedula).HasMaxLength(30);
            entity.Property(e => e.Nacimiento).HasColumnType("date");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.RolId).HasColumnName("RolID");

            entity.HasOne(d => d.Cargo).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("FK__Empleado__CargoI__6E01572D");

            entity.HasOne(d => d.Rol).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__Empleado__RolID__10566F31");
        });

        modelBuilder.Entity<EstadoHabitacion>(entity =>
        {
            entity.HasKey(e => e.EstadoId).HasName("PK__EstadoHa__FEF86B602EB2F79B");

            entity.ToTable("EstadoHabitacion", "Habitaciones");

            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<Habitacion>(entity =>
        {
            entity.HasKey(e => e.HabitacionId).HasName("PK__Habitaci__11AD44414B54FCEB");

            entity.ToTable("Habitacion", "Habitaciones");

            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.CategoriaHabitacionId).HasColumnName("CategoriaHabitacionID");
            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.PisoId).HasColumnName("PisoID");

            entity.HasOne(d => d.CategoriaHabitacion).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.CategoriaHabitacionId)
                .HasConstraintName("FK__Habitacio__Categ__5441852A");

            entity.HasOne(d => d.Estado).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.EstadoId)
                .HasConstraintName("FK__Habitacio__Estad__534D60F1");

            entity.HasOne(d => d.Piso).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.PisoId)
                .HasConstraintName("FK__Habitacio__PisoI__52593CB8");
        });

        modelBuilder.Entity<HistorialEmpleo>(entity =>
        {
            entity.HasKey(e => e.HistorialId).HasName("PK__Historia__975206EF8962051C");

            entity.ToTable("HistorialEmpleo", "RecursosHumanos");

            entity.Property(e => e.HistorialId).HasColumnName("HistorialID");
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaInicio).HasColumnType("date");

            entity.HasOne(d => d.Cargo).WithMany(p => p.HistorialEmpleos)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("FK__Historial__Cargo__14270015");

            entity.HasOne(d => d.Empleado).WithMany(p => p.HistorialEmpleos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Historial__Emple__1332DBDC");
        });

        modelBuilder.Entity<HistorialEstadoHabitacion>(entity =>
        {
            entity.HasKey(e => e.HistorialId).HasName("PK__Historia__975206EFEFE4E8EF");

            entity.ToTable("HistorialEstadoHabitacion", "Habitaciones");

            entity.Property(e => e.HistorialId).HasColumnName("HistorialID");
            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");

            entity.HasOne(d => d.Estado).WithMany(p => p.HistorialEstadoHabitacions)
                .HasForeignKey(d => d.EstadoId)
                .HasConstraintName("FK__Historial__Estad__5812160E");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.HistorialEstadoHabitacions)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK__Historial__Habit__571DF1D5");
        });

        modelBuilder.Entity<Limpieza>(entity =>
        {
            entity.HasKey(e => e.LimpiezaId).HasName("PK__Limpieza__9BAA6B4B468CCB0B");

            entity.ToTable("Limpieza", "Habitaciones");

            entity.Property(e => e.LimpiezaId).HasColumnName("LimpiezaID");
            entity.Property(e => e.ComisionGenerada)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasDefaultValueSql("('Pendiente')");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Limpiezas)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Limpieza__Emplea__04E4BC85");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Limpiezas)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK__Limpieza__Habita__03F0984C");
        });

        modelBuilder.Entity<Mantenimiento>(entity =>
        {
            entity.HasKey(e => e.MantenimientoId).HasName("PK__Mantenim__A62E6142F4110D23");

            entity.ToTable("Mantenimiento", "Habitaciones");

            entity.Property(e => e.MantenimientoId).HasColumnName("MantenimientoID");
            entity.Property(e => e.ComisionGenerada)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasDefaultValueSql("('Pendiente')");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Mantenimientos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Mantenimi__Emple__09A971A2");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Mantenimientos)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK__Mantenimi__Habit__08B54D69");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.PedidoId).HasName("PK__Pedido__09BA141041BFE69E");

            entity.ToTable("Pedido", "Servicios");

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Pedido__ClienteI__6477ECF3");
        });

        modelBuilder.Entity<Piso>(entity =>
        {
            entity.HasKey(e => e.PisoId).HasName("PK__Piso__31BD72C0CFBD0EFB");

            entity.ToTable("Piso", "Habitaciones");

            entity.Property(e => e.PisoId).HasColumnName("PisoID");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE836DBDB315");

            entity.ToTable("Producto", "Servicios");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.CategoriaProductoId).HasColumnName("CategoriaProductoID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaProductoId)
                .HasConstraintName("FK__Producto__Catego__619B8048");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.ReservaId).HasName("PK__Reserva__C39937033DF287AC");

            entity.ToTable("Reserva", "Reservas");

            entity.Property(e => e.ReservaId).HasColumnName("ReservaID");
            entity.Property(e => e.Adelanto)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.TotalGastos)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Reserva__Cliente__5BE2A6F2");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_Reserva_Empleado");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK__Reserva__Habitac__5CD6CB2B");
        });

        modelBuilder.Entity<RolesAcceso>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__RolesAcc__F92302D15E116AAE");

            entity.ToTable("RolesAcceso", "RecursosHumanos");

            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
