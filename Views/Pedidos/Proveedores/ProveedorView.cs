using Hotel.Controllers;
using Hotel.Models;
using Hotel.Views.EmpleadosAsignaciones.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Pedidos.Proveedores
{
    public partial class ProveedorView : Form
    {
        ProveedorController controller;
        public ProveedorView()
        {
            InitializeComponent();
            mostrarProveedores();
        }
        private async void mostrarProveedores()
        {
            using (var cont = new HotelContext())
            {
                controller = new ProveedorController(cont);
                var lista = await controller.GetAllObjectAsync();
                tbProveedor.Rows.Clear();
                foreach (var i in lista)
                {
                    tbProveedor.Rows.Add(i.ProveedorId, i.NombreEmpresa, i.NombreContacto, i.CargoContacto,
                        i.Telefono, i.Fax, i.Direcccion + "-" + i.Ciudad + "-" + i.Pais, "", "");
                }
            }
        }
        private async void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            using (var cont = new HotelContext())
            {
                controller = new ProveedorController(cont);
                int indice = e.RowIndex;
                if (tbProveedor.Columns[e.ColumnIndex].Name == "Borrar")
                {
                    try
                    {
                        int id = (int)tbProveedor.Rows[indice].Cells["Id"].Value;

                        if (MessageBox.Show("¿Esta seguro de eliminar al proveedor seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            controller.DeleteObjectAsync(id);
                            MessageBox.Show("Proveedor eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No puedes eliminar el cargo seleccionado ya que existen empleados con el asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (tbProveedor.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int ClienteId = Convert.ToInt32(tbProveedor.Rows[indice].Cells["Id"].Value);
                    var cargo = await controller.GetObjectAsync(ClienteId);
                    ProveedorViewRegister form = new ProveedorViewRegister(cargo);
                    form.ShowDialog();

                }
            }
            mostrarProveedores();
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
            ProveedorViewRegister form = new ProveedorViewRegister(null);
            form.ShowDialog();
            mostrarProveedores();
        }
    }
}
