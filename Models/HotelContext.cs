using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Models;

public partial class HotelContext : DbContext
{
    public HotelContext()
    {
    }

    public HotelContext(DbContextOptions<HotelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asignacion> Asignacions { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CategoriaHabitacion> CategoriaHabitacions { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

    public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EstadoHabitacion> EstadoHabitacions { get; set; }

    public virtual DbSet<Habitacion> Habitacions { get; set; }

    public virtual DbSet<MovimientoProducto> MovimientoProductos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Piso> Pisos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=Hotel;Integrated Security=true;Trust Server Certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asignacion>(entity =>
        {
            entity.HasKey(e => e.AsignacionId).HasName("PK__Asignaci__D82B5BB7B400CC7B");

            entity.ToTable("Asignacion", "RecursosHumanos");

            entity.Property(e => e.AsignacionId).HasColumnName("AsignacionID");
            entity.Property(e => e.ComisionGenerada).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaConclusion).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.TipoAsignacion).HasMaxLength(50);

            entity.HasOne(d => d.Empleado).WithMany(p => p.Asignacions)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_TipoAsignacion_Empleado");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Asignacions)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK_TipoAsignacion_Habitacion");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.CargoId).HasName("PK__Cargo__B4E665ED4E594D5D");

            entity.ToTable("Cargo", "RecursosHumanos");

            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.SalarioBasePh)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SalarioBasePH");
        });

        modelBuilder.Entity<CategoriaHabitacion>(entity =>
        {
            entity.HasKey(e => e.CategoriaHabitacionId).HasName("PK__Categori__52EEE3CD67515A1E");

            entity.ToTable("CategoriaHabitacion", "Habitaciones");

            entity.Property(e => e.CategoriaHabitacionId).HasColumnName("CategoriaHabitacionID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.CategoriaProductoId).HasName("PK__Categori__7C808EDC16D4992D");

            entity.ToTable("CategoriaProducto", "Servicios");

            entity.Property(e => e.CategoriaProductoId).HasColumnName("CategoriaProductoID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Cliente__71ABD0A7FB66E311");

            entity.ToTable("Cliente", "Reservas");

            entity.HasIndex(e => e.Email, "UQ__Cliente__A9D10534FAC39378").IsUnique();

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.Cedula).HasMaxLength(30);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__Compra__067DA725A9BE88F3");

            entity.ToTable("Compra", "Servicios");

            entity.Property(e => e.CompraId).HasColumnName("CompraID");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Compras)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Compra_Usuario");
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => new { e.CompraId, e.ProductoId }).HasName("PK__DetalleC__2C3EADCD2FC0796B");

            entity.ToTable("DetalleCompra", "Servicios", tb => tb.HasTrigger("trg_agregar_movimiento_venta"));

            entity.Property(e => e.CompraId).HasColumnName("CompraID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Compra).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.CompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Compra");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Producto");
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => new { e.PedidoId, e.ProductoId }).HasName("PK__DetalleP__23F91EF89CA4EAAB");

            entity.ToTable("DetallePedido", "Servicios", tb => tb.HasTrigger("trg_agregar_movimiento_compra"));

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.Pedido).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallePedido_Pedido");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetallePe__Produ__628FA481");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__958BE6F06D3A44EF");

            entity.ToTable("Empleado", "RecursosHumanos");

            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.CargoId).HasColumnName("CargoID");
            entity.Property(e => e.Cedula).HasMaxLength(30);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.Nacimiento).HasColumnType("date");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Cargo).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("FK__Empleado__CargoI__5CD6CB2B");
        });

        modelBuilder.Entity<EstadoHabitacion>(entity =>
        {
            entity.HasKey(e => e.EstadoId).HasName("PK__EstadoHa__FEF86B60CF48DCAE");

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
            entity.Property(e => e.Codigo).HasMaxLength(10);
            entity.Property(e => e.Detalles).HasMaxLength(300);
            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.Extras).HasMaxLength(150);
            entity.Property(e => e.PisoId).HasColumnName("PisoID");
            entity.Property(e => e.PrecioPh)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PrecioPH");

            entity.HasOne(d => d.CategoriaHabitacion).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.CategoriaHabitacionId)
                .HasConstraintName("FK_Habitacion_CategoriaHabitacion");

            entity.HasOne(d => d.Estado).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.EstadoId)
                .HasConstraintName("FK_Habitacion_EstadoHabitacion");

            entity.HasOne(d => d.Piso).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.PisoId)
                .HasConstraintName("FK_Habitacion_Piso");
        });

        modelBuilder.Entity<MovimientoProducto>(entity =>
        {
            entity.HasKey(e => e.MovimientoId).HasName("PK__Movimien__BF923FCCBBD9B950");

            entity.ToTable("MovimientoProducto", "Servicios");

            entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.UltimoPrecio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Producto).WithMany(p => p.MovimientoProductos)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_STOCK_PRODUCTO");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.PedidoId).HasName("PK__Pedido__09BA141096F4E3D9");

            entity.ToTable("Pedido", "Servicios");

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ReservaId).HasColumnName("ReservaID");

            entity.HasOne(d => d.Reserva).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.ReservaId)
                .HasConstraintName("FK_Pedido_Reserva");
        });

        modelBuilder.Entity<Piso>(entity =>
        {
            entity.HasKey(e => e.PisoId).HasName("PK__Piso__31BD72C03CF7103E");

            entity.ToTable("Piso", "Habitaciones");

            entity.Property(e => e.PisoId).HasColumnName("PisoID");
            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE83595CD79C");

            entity.ToTable("Producto", "Servicios");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.CategoriaProductoId).HasColumnName("CategoriaProductoID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.Stock).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaProductoId)
                .HasConstraintName("FK__Producto__Catego__656C112C");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Productos)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_Producto_Proveedor");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.ProveedorId).HasName("PK__Proveedo__61266BB976146A1E");

            entity.ToTable("Proveedor", "Servicios");

            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.CargoContacto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Ciudad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Direcccion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(24)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.ReservaId).HasName("PK__Reserva__C399370332B687C8");

            entity.ToTable("Reserva", "Reservas");

            entity.Property(e => e.ReservaId).HasColumnName("ReservaID");
            entity.Property(e => e.Adelanto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.HabitacionId).HasColumnName("HabitacionID");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalDaños).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Reserva_Cliente");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_Reserva_Empleado");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK_Reserva_Habitacion");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__Rol__F92302D1B9358A4F");

            entity.ToTable("Rol", "RecursosHumanos");

            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuario__2B3DE79869B71642");

            entity.ToTable("Usuario", "RecursosHumanos", tb => tb.HasTrigger("trg_encript_password"));

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Clave).HasMaxLength(300);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(100)
                .HasColumnName("Usuario");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_Usuario_Empleado");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK_Usuario_Rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
