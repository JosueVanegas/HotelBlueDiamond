using Hotel.Controllers;
using Hotel.Models;
using Hotel.View.ClientesView;
using Hotel.Views.Habitaciones.Habitaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Habitaciones
{
    public partial class HabitacionesView : Form
    {
        HotelContext context;
        HabitacionesController controller;
        public HabitacionesView()
        {
            InitializeComponent();
            context = new HotelContext();
            controller = new HabitacionesController(context);
            mostrarHabitaciones();
        }
        private void mostrarHabitaciones()
        {
            try
            {
                context = new HotelContext();
                controller = new HabitacionesController(context);
                var lista = controller.GetAllObjects();
                tbHabitaciones.Rows.Clear();
                foreach (var i in lista)
                {
                    tbHabitaciones.Rows.Add(i.HabitacionId, i.Codigo, i.CategoriaHabitacion.Descripcion, i.Piso.Descripcion, i.PrecioPh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbHabitaciones.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbHabitaciones.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar la habitación seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarHabitaciones();
                        MessageBox.Show("Cliente eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbHabitaciones.Columns[e.ColumnIndex].Name == "Editar")
            {

                int id = Convert.ToInt32(tbHabitaciones.Rows[indice].Cells["Id"].Value);

                Habitacion habitacion = controller.GetObjectById(id);

                HabitacionesViewRegister form = new HabitacionesViewRegister(habitacion);
                mostrarHabitaciones();
            }
        }
        private void cellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.editarImg.Height;
                var w = Properties.Resources.editarImg.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editarImg, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 6)
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
            HabitacionesViewRegister form = new HabitacionesViewRegister(null);
            mostrarHabitaciones();
        }
    }
    //estados posibles values('Disponible'),('No disponible'),('En Limpieza'),('En Mantenimiento')
}
