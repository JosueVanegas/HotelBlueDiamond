using Hotel.Models;
using Hotel.View.ClientesView;
using Hotel.Views.Ayudas;
using Hotel.Views.EmpleadosAsignaciones.Asignaciones;
using Hotel.Views.EmpleadosAsignaciones.Personal;
using Hotel.Views.GestionView;
using Hotel.Views.GestionView.Recepcion;
using Hotel.Views.Habitaciones;
using Hotel.Views.Home;
using Hotel.Views.Informes;
using Hotel.Views.Pedidos.Compras;
using Hotel.Views.Pedidos.Productos;
using Hotel.Views.Pedidos.Proveedores;
using Hotel.Views.Pedidos.Ventas;
using Hotel.Views.Usuarios;
using Microcharts;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Home
{
    public partial class HomeView : Form
    {
        Usuario usuario;
        public HomeView(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.DoubleBuffered = true;
        }
        private void llenarDatosUsuario()
        {
            if (usuario != null)
            {
                string datos = $"Nombre de usuario: {usuario.Usuario1}          |          Persona asignada: {usuario.Empleado.Nombre} {usuario.Empleado.Apellido}          |          Rol de usuario: {usuario.Rol.Descripcion} ";
                lblUsuario.Text = datos;
                validarAccesos();
            }
        }
        private void validarAccesos()
        {
            switch (usuario.RolId)
            {
                case 1:
                    break;
                //recepcionista
                case 2:
                    desactivarComponente(btnUsuariosMenu);
                    desactivarComponente(btnReportesMenu);
                    desactivarComponente(btnCompraSubMenu);
                    desactivarComponente(btnInventarioSubMenu);
                    desactivarComponente(btnEmpleadosMenu);
                    desactivarComponente(btnHabitacionesMenu);
                    desactivarComponente(btnReportesMenu);
                    break;
                //bodeguero
                case 3:
                    desactivarComponente(btnEmpleadosMenu);
                    desactivarComponente(btnHabitacionesMenu);
                    desactivarComponente(btnRecepcionMenu);
                    desactivarComponente(btnUsuariosMenu);
                    desactivarComponente(btnClientesMenu);
                    desactivarComponente(btnServicioHabitacion);
                    desactivarComponente(btnInformeHospedajes);
                    desactivarComponente(btnInformeNomina);
                    break;
                //contador
                case 4:
                    desactivarComponente(btnEmpleadosMenu);
                    desactivarComponente(btnHabitacionesMenu);
                    desactivarComponente(btnRecepcionMenu);
                    desactivarComponente(btnUsuariosMenu);
                    desactivarComponente(btnClientesMenu);
                    desactivarComponente(btnTiendaMenu);
                    break;
                default:
                    this.Close();
                    MessageBox.Show("Rol no encontrado", "Error de rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void desactivarComponente(ToolStripMenuItem tool)
        {
            if (tool != null)
            {
                tool.Enabled = false;
                tool.Visible = false;
            }
        }
        private void HomeView_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.usuario = usuario;
            llenarDatosUsuario();
            Reloj.Start();
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.TransparencyKey = Color.Empty;
            abrirFormulario(new DashBoardView());
            foreach (ToolStripMenuItem item in Menu.Items)
            {
                item.DropDownOpened += Item_DropDownOpened;
                item.DropDownClosed += Item_DropDownClosed;
            }
            this.Cursor = Cursors.Default;
        }
        private void abrirFormulario(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ClientView());
        }
        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new HabitacionesView());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CategoriasHabitacionView());
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString();
        }
        private void Item_DropDownOpened(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in Menu.Items)
            {
                item.BackColor = Color.Transparent;
            }
            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            if (selectedItem != null)
            {
                selectedItem.BackColor = Color.LightBlue;
                selectedItem.ForeColor = Color.Black;
            }
        }

        private void Item_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem closedItem = sender as ToolStripMenuItem;
            if (closedItem != null)
            {
                closedItem.BackColor = Color.Transparent;
                closedItem.ForeColor = Color.Beige;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new EmpleadosView());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CargosView());
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AsignacionView());
        }

        private void btnAyudaMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AyudaView());
        }

        private void btnHospedajeMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ReservaViewResume(this.usuario));
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ProductoView());
        }

        private void btnUsuariosMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new UsuariosView());
        }

        private void btnInicioMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new DashBoardView());
        }

        private void categoriasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CategoriasView());
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar de usuario?", "Cambiar de usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ProveedorView());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new VentaView());
        }

        private void informeDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            informeInventario();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ComprasView(this.usuario.UsuarioId));
        }

        private void btnInformeHospedajes_Click(object sender, EventArgs e)
        {
            CrearInformePDF form = new CrearInformePDF(2);
            form.ShowDialog();
        }

        private void btnInformeNomina_Click(object sender, EventArgs e)
        {
            CrearInformePDF form = new CrearInformePDF(3);
            form.ShowDialog();
        }
        private void informeInventario()
        {
            var doc = QuestPDF.Fluent.Document.Create(container =>
            {
                const string colorFondoInventario = "#439EBE";
                const string transparentBlue = "#439EBE ";
                var context = new HotelContext();
                var listaProductos = context.Productos.Include(c => c.CategoriaProducto).ToList();
                var listaMasVendidos = context.DetallePedidos.Include(d => d.Producto).Take(10).ToList();
                container.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);
                    page.Background().AlignTop().ExtendHorizontal().Height(110).Background(colorFondoInventario);
                    page.Foreground().AlignBottom().ExtendHorizontal().Height(50).Background(transparentBlue);

                    page.Header().Column(c =>
                    {
                        c.Item().Row(row =>
                        {
                            row.ConstantItem(40).Border(0).Background(Colors.Transparent).Height(100).Column(col =>
                            {

                            });
                            row.RelativeItem().Border(0).Background(Colors.Transparent).Height(100).Column(col =>
                            {
                                col.Item().AlignCenter().Text("Blue Diamond").FontSize(30).Bold();
                                col.Item().AlignCenter().Text("Teléfono: +505 8349-2395").FontSize(9);
                                col.Item().AlignCenter().Text("Correo electronico: BlueDiamond@gmail.com").FontSize(9);
                                col.Item().AlignCenter().Text("Direccion: Managua,managua costado sur de metrocentro").FontSize(9);
                            });
                            row.ConstantItem(40).Border(0).Background(Colors.Transparent).Height(100);
                        });
                    });

                    page.Content().Column(c =>
                    {
                        c.Item().PaddingVertical(25).Column(column =>
                        {
                            column.Item().AlignCenter().Text("Reporte de inventario").FontSize(25);
                            column.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Fecha de elaboración del informe: ").FontSize(15);
                                txt.Span(DateTime.Now.ToString()).FontSize(15);

                            });
                            column.Spacing(30);

                            column.Item().LineHorizontal(0.5f);


                            /*
                             * var entries = new List<ChartEntry>();
                          CultureInfo cultureInfo = new CultureInfo("es-ES");
                          foreach (var i in listaMasVendidos)
                          {
                              entries.Add(new ChartEntry((float)i.Cantidad)
                              {
                                  Label = i.Producto.Descripcion,
                                  ValueLabel = i.Cantidad.ToString(),
                                  Color = SKColor.Parse("#87CEEB")
                              });
                          }
                          column.Item().Column(column =>
                          {
                              var titleStyle = TextStyle
                                .Default
                               .FontSize(15)
                               .SemiBold()
                                 .FontColor(Colors.Blue.Medium);
                              column
                                  .Item()
                                  .PaddingBottom(1)
                                  .Text("Grafica de los 10 productos y sus cantidades más vendidos hasta la fecha")
                               .Style(titleStyle);

                              column
                            .Item()
                         .Border(1)
                         .ExtendHorizontal()
                         .Height(200)
                            .Canvas((canvas, size) =>
                            {
                                var chart = new BarChart
                                {
                                    Entries = entries,

                                    LabelOrientation = Microcharts.Orientation.Horizontal,
                                    ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                    IsAnimated = false,
                                };

                                chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                            });
                          });

                          column.Spacing(10);
                             */


                            column.Item().AlignCenter().Text("Inventario actual").FontSize(15);


                            column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                            {
                                tab.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(3);
                                });

                                tab.Header(het =>
                                {
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Producto").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Categoria").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Precio unitario").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Stock").FontSize(10);

                                });
                                decimal valorInventario = 0;
                                foreach (var i in listaProductos)
                                {
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Descripcion).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.CategoriaProducto.Descripcion).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Precio).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Stock).FontSize(11);
                                    valorInventario += Convert.ToDecimal(i.Precio * i.Stock);

                                }
                                column.Item().Row(row =>
                                {
                                    row.RelativeItem().Column(col =>
                                    {
                                        col.Item().AlignRight().Text(txt =>
                                        {
                                            txt.Span("      Valor del inventario actual: " + valorInventario + " C$").FontSize(15);
                                        });
                                    });
                                });
                            });

                        });
                    });
                    page.Footer().Column(c =>
                    {
                        c.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Pagina  ").FontSize(10);
                            txt.CurrentPageNumber().FontSize(10);
                            txt.Span("  de  ").FontSize(10);
                            txt.TotalPages().FontSize(10);
                        });
                    });
                });
            });
            QuestPDF.Settings.License = LicenseType.Community;
            var filePath = "informeInventario.pdf";
            doc.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
        }
    }
}