using Hotel.Controllers;
using Hotel.Models;
using Hotel.View.ClientesView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Pedidos.Productos
{
    public partial class ProductoView : Form
    {
        HotelContext context;
        ProductoController controller;
        public ProductoView()
        {
            InitializeComponent();
            context = new HotelContext();
            controller = new ProductoController(context);
            mostrarProductos();
        }
        private async void mostrarProductos()
        {
            context = new HotelContext();
            controller = new ProductoController(context);
            var lista = await controller.GetAllObject();
            tbProductos.Rows.Clear();
            foreach (var i in lista)
            {
                tbProductos.Rows.Add(i.ProductoId, i.Descripcion, i.Precio,i.Stock, i.CategoriaProducto.Descripcion,i.Proveedor.NombreEmpresa, "", "");
            }
        }
        private async void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbProductos.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbProductos.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar el producto seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarProductos();
                        MessageBox.Show("Producto eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = Convert.ToInt32(tbProductos.Rows[indice].Cells["Id"].Value);
                var prod = await controller.GetObject(id);
                ProductoViewRegister form = new ProductoViewRegister(prod);
                mostrarProductos();
            }
        }
        private void cellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.editarImg.Height;
                var w = Properties.Resources.editarImg.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editarImg, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 7)
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ProductoViewRegister form = new ProductoViewRegister(null);
            mostrarProductos();
        }
    }
}
