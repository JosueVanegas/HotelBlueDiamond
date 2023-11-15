using Hotel.Controllers;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Pedidos.Compras
{
    public partial class ComprasView : Form
    {
        int usuarioID;
        public ComprasView(int usuarioID)
        {
            InitializeComponent();
            this.usuarioID = usuarioID; 
            mostrarProductos();
        }
        private async void mostrarProductos()
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var controller = new ProductoController(context);
                    var lista = await controller.GetAllObject();
                    foreach (var i in lista)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                    if (txtTotal.Text != "")
                    {
                    var compra = new Compra
                    {
                        UsuarioId = usuarioID,
                            Fecha = DateTime.Now,
                        };
                        int _idPedido;
                        using (var context = new HotelContext())
                        {
                            var controller = new CompraController(context);
                            int _idCompra = await controller.AddObject(compra);
                            if (_idCompra != 0)
                            {
                                foreach (DataGridViewRow i in tbDetalles.Rows)
                                {
                                    var idProducto = Convert.ToInt32(i.Cells["Id"].Value);
                                    var cantidad = Convert.ToInt32(i.Cells["Cantidad"].Value);
                                    var ultimoPrecio = Convert.ToInt32(i.Cells["Precio"].Value);
                                    var detalle = new DetalleCompra
                                    {
                                        CompraId = _idCompra,
                                        ProductoId = idProducto,
                                        PrecioCompra = ultimoPrecio,
                                        Cantidad = cantidad,
                                    };
                                    controller.AddDetalles(detalle);
                                controller.ChageStockProductLess(idProducto, cantidad);
                                }
                            txtTotal.Text = string.Empty;
                                MessageBox.Show("La compra ha sido registrada correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha agregado nada aun", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
