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

namespace Hotel.Views.Pedidos.Productos
{
    public partial class CategoriasView : Form
    {
        HotelContext context;
        CategoriaProductoController controller;
        public CategoriasView()
        {
            InitializeComponent();
            mostrarCategorias();
        }
        private void mostrarCategorias()
        {
            context = new HotelContext();
            controller = new CategoriaProductoController(context);
            var lista = controller.GetAllObject();
            tbCategoria.Rows.Clear();
            foreach (var i in lista)
            {
                tbCategoria.Rows.Add(i.CategoriaProductoId, i.Descripcion, "", "");
            }
        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbCategoria.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbCategoria.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar la categoria seleccionada seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarCategorias();
                        MessageBox.Show("Categoria eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbCategoria.Columns[e.ColumnIndex].Name == "Editar")
            {
                int ClienteId = Convert.ToInt32(tbCategoria.Rows[indice].Cells["Id"].Value);
                var cliente = controller.GetObject(ClienteId);
                CategoriasViewRegister form = new CategoriasViewRegister(cliente);
                form.ShowDialog();
                mostrarCategorias();
            }
        }
        private void cellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.editarImg.Height;
                var w = Properties.Resources.editarImg.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editarImg, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 3)
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
            CategoriasViewRegister form = new CategoriasViewRegister(null);
            form.ShowDialog();
            mostrarCategorias();
        }
    }
}
