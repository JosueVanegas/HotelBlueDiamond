using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.View.ClientesView;
using Hotel_Dorado_DesktopApp.Views.Habitaciones.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.Habitaciones
{
    public partial class CategoriasHabitacionView : Form
    {
        HotelDoradoContext context;
        CategoriaHabitacionesController controller;
        public CategoriasHabitacionView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new CategoriaHabitacionesController(context);
            mostrarCategorias();
        }
        private void mostrarCategorias()
        {
            context = new HotelDoradoContext();
            controller = new CategoriaHabitacionesController(context);
            var lista = controller.GetAllObjects();
            tbCategorias.Rows.Clear();
            foreach (var i in lista)
            {
                tbCategorias.Rows.Add(i.CategoriaHabitacionId, i.Descripcion, i.Capacidad, "", "");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CategoriaHabitacionViewRegister form = new CategoriaHabitacionViewRegister(null);
            form.ShowDialog();
            mostrarCategorias();
        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbCategorias.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbCategorias.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar la categoria seleccionada?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarCategorias();
                        MessageBox.Show("Categoria eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbCategorias.Columns[e.ColumnIndex].Name == "Editar")
            {
                CategoriaHabitacion ch = new CategoriaHabitacion
                {
                    CategoriaHabitacionId = Convert.ToInt32(tbCategorias.Rows[indice].Cells["ID"].Value),
                    Descripcion = tbCategorias.Rows[indice].Cells["Nombre"].Value.ToString(),
                    Capacidad = Convert.ToInt32(tbCategorias.Rows[indice].Cells["Cantidad"].Value.ToString())
                };
                CategoriaHabitacionViewRegister form = new CategoriaHabitacionViewRegister(ch);
                form.ShowDialog();
                mostrarCategorias();
            }
        }
        private void cellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.editarImg.Height;
                var w = Properties.Resources.editarImg.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editarImg, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 4)
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
