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

namespace Hotel.Views.EmpleadosAsignaciones.Personal
{
    public partial class EmpleadosView : Form
    {
        public EmpleadosView()
        {
            InitializeComponent();
            mostrarEmpleados();
        }
        private async void mostrarEmpleados()
        {
            var context = new HotelContext();
            var controller = new EmpleadosController(context);
            var lista = await controller.GetAllObjects();
            tbEmpleados.Rows.Clear();
            foreach (var i in lista)
            {
                tbEmpleados.Rows.Add(i.EmpleadoId, i.Cedula, i.Nombre, i.Apellido, i.Nacimiento, i.Cargo.Descripcion, "", "");
            }
        }
        private async void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new HotelContext();
            var controller = new EmpleadosController(context);
            int indice = e.RowIndex;
            if (tbEmpleados.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbEmpleados.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar al empleado seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarEmpleados();
                        MessageBox.Show("Empleado eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = Convert.ToInt32(tbEmpleados.Rows[indice].Cells["Id"].Value);
                var empleado = await controller.GetObjectById(id);
                EmpleadosViewRegister form = new EmpleadosViewRegister(empleado);
                form.ShowDialog();
                mostrarEmpleados();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EmpleadosViewRegister form = new EmpleadosViewRegister(null);
            form.ShowDialog();
            mostrarEmpleados();
        }
    }
}
