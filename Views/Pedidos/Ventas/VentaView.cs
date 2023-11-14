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
        int ReservaID;
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
                        int existingRowIndex = -1;
                        foreach (DataGridViewRow row in tbDetalles.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Id"].Value) == i.ProductoId)
                            {
                                existingRowIndex = row.Index;
                                break;
                            }
                        }
                        if (existingRowIndex != -1)
                        {
                            var cantidad = Convert.ToInt32(tbDetalles.Rows[existingRowIndex].Cells["Cantidad"].Value);
                            tbDetalles.Rows[existingRowIndex].Cells["Cantidad"].Value = cantidad + 1;
                            var precio = Convert.ToDecimal(tbDetalles.Rows[existingRowIndex].Cells["Precio"].Value);
                            tbDetalles.Rows[existingRowIndex].Cells["Subtotal"].Value = precio * (cantidad + 1);
                        }
                        else
                        {
                            var subTotal = i.Precio * 1;
                            tbDetalles.Rows.Add(i.ProductoId, i.Descripcion, i.CategoriaProducto.Descripcion, i.Precio, 1, subTotal, "", "", "");
                        }
                        calcularTotal();
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
                                    using (var context = new HotelContext())
                                    {
                                        var controller = new RecepcionController(context);
                                        var reserva = controller.GetReservaByHabitacion(i.HabitacionId);
                                        txtApellido.Text = reserva.Cliente.Apellido;
                                        txtNombre.Text = reserva.Cliente.Nombre;
                                        txtCedula.Text = reserva.Cliente.Cedula;
                                        txtNumero.Text = i.Codigo;
                                        txtPiso.Text = i.Piso.Descripcion;
                                        txtCategoria.Text = i.CategoriaHabitacion.Descripcion;
                                        ReservaID = reserva.ReservaId;
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
            var nuevaCantidad = 0;
            var cantidad = 0;
            cantidad = Convert.ToInt32(tbDetalles.Rows[indice].Cells["Cantidad"].Value);


            if (tbDetalles.Columns[e.ColumnIndex].Name == "Agregar")
            {
                nuevaCantidad = cantidad + 1;
            }
            if (tbDetalles.Columns[e.ColumnIndex].Name == "Quitar")
            {
                if (cantidad >= 1)
                {
                    nuevaCantidad = cantidad - 1;
                }
            }
            tbDetalles.Rows[indice].Cells["Cantidad"].Value = nuevaCantidad;
            var precio = Convert.ToDecimal(tbDetalles.Rows[indice].Cells["Precio"].Value);
            tbDetalles.Rows[indice].Cells["Subtotal"].Value = precio * nuevaCantidad;
            if (tbDetalles.Columns[e.ColumnIndex].Name == "Borrar")
            {
                tbDetalles.Rows.RemoveAt(indice);
            }
            calcularTotal();
        }
        private void cellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.agregar.Height;
                var w = Properties.Resources.agregar.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.agregar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.quitar.Height;
                var w = Properties.Resources.quitar.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.quitar, new Rectangle(x, y, w, h));
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
        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow i in tbDetalles.Rows)
            {
                if (i != null)
                {
                    total += Convert.ToDecimal(i.Cells["subTotal"].Value);
                }
            }
            txtTotal.Text = total.ToString();
        }
        private void limpiarCampos()
        {
            txtApellido.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtPiso.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNumero.Text = string.Empty;
            tbDetalles.Rows.Clear();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txtNumero.Text != "")
                {
                    if (txtTotal.Text != "")
                    {
                        var cancelado = ckbCancelado.Checked;
                        var pedido = new Pedido
                        {
                            ReservaId = ReservaID,
                            Estado = cancelado,
                            Fecha = DateTime.Now,
                        };
                        int _idPedido;
                        using (var context = new HotelContext())
                        {
                            var controller = new PedidoControllercs(context);
                            _idPedido = controller.AddObject(pedido);
                            if (_idPedido != 0)
                            {
                                foreach (DataGridViewRow i in tbDetalles.Rows)
                                {
                                    var idProducto = Convert.ToInt32(i.Cells["Id"].Value);
                                    var cantidad = Convert.ToInt32(i.Cells["Cantidad"].Value);
                                    var detalle = new DetallePedido
                                    {
                                        PedidoId = _idPedido,
                                        ProductoId = idProducto,
                                        Cantidad = cantidad,
                                    };
                                    controller.AddDetalles(detalle);
                                }
                                limpiarCampos();
                                MessageBox.Show("El pedido ha sido registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha comprado nada aun", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la habitación a la que se le enviara el pedido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }
    }
}

