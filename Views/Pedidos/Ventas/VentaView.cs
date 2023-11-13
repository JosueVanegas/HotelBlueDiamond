using Hotel.Controllers;
using Hotel.Models;
using Hotel.View.ClientesView;
using Hotel.Views.Gestion.Salidas;
using Hotel.Views.GestionView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Pedidos.Ventas
{
    public partial class VentaView : Form
    {
        ProductoController controller;
        public VentaView()
        {
            InitializeComponent();
            showPurchase();
            carouselHub();
            mostrarHabitaciones();
        }
        private void showPurchase()
        {

        }
        private async void carouselHub()
        {
            using (var context = new HotelContext())
            {
                controller = new ProductoController(context);
                var list = await controller.GetAllObject();
                foreach (var i in list)
                {
                    var panel = new Panel
                    {
                        Height = 150,
                        Width = 150,
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,

                    };
                    var labelSup = new Label
                    {
                        BackColor = Color.Blue,
                        Height = 15,
                        Dock = DockStyle.Top
                    };
                    var HNumber = new Label
                    {
                        Text = "Producto: \n" + i.Descripcion + "\n" + "Precio: \n" + i.Precio,
                        BackColor = Color.LightBlue,
                        ForeColor = Color.Blue,
                        Dock = DockStyle.Top,
                        Height = 80,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    var boton = new Button
                    {
                        Text = "Agregar al carrito",
                        Height = 40,
                        Width = 80,
                        Dock = DockStyle.Bottom,
                        BackColor = Color.ForestGreen,
                        ForeColor = Color.White,
                        Cursor = Cursors.Hand,
                    };
                    boton.Click += (s, e) =>
                    {
                        var subTotal = i.Precio * 1;
                        tbDetalles.Rows.Add(i.ProductoId, i.Descripcion, i.CategoriaProducto.Descripcion, i.Precio,1 ,subTotal,"","","");
                    };
                    panel.Controls.Add(boton);
                    panel.Controls.Add(HNumber);
                    panel.Controls.Add(labelSup);

                    panelCarousel.Controls.Add(panel);
                }
            }
        }
        private async void mostrarHabitaciones()
        {
            using (var context = new HotelContext())
            {
                try
                {
                    int itemWidth = 150;
                    int itemHeight = 150;

                    var habitaciones = new HabitacionesController(context).GetAllObjects();
                    if (habitaciones.Count != 0)
                    {
                        int index = 0;
                        foreach (var i in habitaciones)
                        {
                            if (i.EstadoId == 2)
                            {
                                var panel = new Panel
                                {
                                    Width = itemWidth,
                                    Height = itemHeight,
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Left = index * itemWidth,
                                };
                                var label2 = new Label
                                {
                                    ForeColor = Color.FromArgb(0, 51, 102),
                                    Text = "Estado: \n" + i.Estado.Descripcion,
                                    Dock = DockStyle.Top,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Height = 40,
                                    BackColor = Color.LightGray
                                };
                                panel.Controls.Add(label2);

                                var label1 = new Label
                                {
                                    ForeColor = Color.FromArgb(0, 51, 102),
                                    Text = "Habitación numero: \n" + i.Codigo,
                                    Dock = DockStyle.Top,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Height = 40,
                                    BackColor = Color.White
                                };
                                panel.Controls.Add(label1);
                                var boton = new Button
                                {
                                    Text = "Seleccionar",
                                    Dock = DockStyle.Bottom,
                                    Size = new Size(itemWidth, 40),
                                    BackColor = Color.FromArgb(0, 51, 102),
                                    ForeColor = Color.White
                                };
                                boton.Click += (s, e) =>
                                {
                                    using(var context = new HotelContext())
                                    {
                                        var controller = new RecepcionController(context);
                                        var reserva = controller.GetReservaByHabitacion(i.HabitacionId);
                                        txtApellido.Text = reserva.Cliente.Apellido;
                                        txtNombre.Text = reserva.Cliente.Nombre;
                                        txtCedula.Text = reserva.Cliente.Cedula;
                                        txtNumero.Text = i.Codigo;
                                        txtPiso.Text = i.Piso.Descripcion;
                                        txtCategoria.Text = i.CategoriaHabitacion.Descripcion;
                                    }
                                };
                                panel.Controls.Add(boton);
                                this.panelHabitaciones.Controls.Add(panel);
                                index++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay habitaciones registradas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbDetalles.Columns[e.ColumnIndex].Name == "Borrar")
            {
                tbDetalles.Rows.RemoveAt(indice);


            }
            if (tbDetalles.Columns[e.ColumnIndex].Name == "Agregar")
            {
                int cantidad = Convert.ToInt32(tbDetalles.Rows[indice].Cells["Cantidad"].Value);
                tbDetalles.Rows[indice].Cells["Cantidad"].Value = cantidad + 1;
            }
            if (tbDetalles.Columns[e.ColumnIndex].Name == "Quitar")
            {
                int cantidad = Convert.ToInt32(tbDetalles.Rows[indice].Cells["Cantidad"].Value);
               if(cantidad != 1)
                {
                    tbDetalles.Rows[indice].Cells["Cantidad"].Value = cantidad - 1;
                }
            }
        }
        private void cellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.editarImg.Height;
                var w = Properties.Resources.editarImg.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editarImg, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.eliminarImg.Width;
                var h = Properties.Resources.eliminarImg.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.eliminarImg, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}

