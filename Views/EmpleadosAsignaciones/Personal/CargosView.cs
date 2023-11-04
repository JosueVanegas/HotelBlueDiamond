using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.View.ClientesView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.EmpleadosAsignaciones.Personal
{
    public partial class CargosView : Form
    {
        HotelDoradoContext context;
        public CargosView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            mostrarCargos();
        }
        private void mostrarCargos()
        {
            context = new HotelDoradoContext();
            var controller = new CargosController(context);
            tbCargos.Rows.Clear();
            var lista = controller.GetAllObject();
            foreach (var i in lista)
            {
                tbCargos.Rows.Add(i.CargoId, i.Descripcion, i.SalarioBasePh, "", "");
            }
        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var controller = new CargosController(context);
            int indice = e.RowIndex;
            if (tbCargos.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbCargos.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar el cargo seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarCargos();
                        MessageBox.Show("Cargo eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No puedes eliminar el cargo seleccionado ya que existen empleados con el asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbCargos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int ClienteId = Convert.ToInt32(tbCargos.Rows[indice].Cells["Id"].Value);
                var cargo = controller.GetObjectById(ClienteId);
                CargosViewRegister form = new CargosViewRegister(cargo);
                form.ShowDialog();
                mostrarCargos();
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CargosViewRegister form = new CargosViewRegister(null);
            form.ShowDialog();
            mostrarCargos();
        }

    }
}
