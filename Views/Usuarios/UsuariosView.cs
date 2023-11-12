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

namespace Hotel.Views.Usuarios
{
    public partial class UsuariosView : Form
    {
        HotelContext context;
        public UsuariosView()
        {
            InitializeComponent();
            mostrarUsuarios();
        }
        private void mostrarUsuarios()
        {
            context = new HotelContext();
            var controller = new UsuarioController(context);
            tbUsuario.Rows.Clear();
            var lista = controller.GetAllObject();
            foreach (var i in lista)
            {
                tbUsuario.Rows.Add(i.UsuarioId, i.Usuario1, i.Empleado.Nombre, i.Empleado.Apellido, i.Rol.Descripcion, "", "");
            }
        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            context = new HotelContext();
            var controller = new UsuarioController(context);
            if (tbUsuario.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbUsuario.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar al usuario seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarUsuarios();
                        MessageBox.Show("Usuario eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbUsuario.Columns[e.ColumnIndex].Name == "Editar")
            {
                int ClienteId = Convert.ToInt32(tbUsuario.Rows[indice].Cells["Id"].Value);
                var cliente = controller.GetObjectById(ClienteId);
                UsuariosViewRegister form = new UsuariosViewRegister(cliente);
                form.ShowDialog();
                mostrarUsuarios();
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
            UsuariosViewRegister form = new UsuariosViewRegister(null);
            form.ShowDialog();
            mostrarUsuarios();
        }
    }
}
