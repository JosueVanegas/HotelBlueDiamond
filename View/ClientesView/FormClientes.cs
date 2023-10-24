using Hotel_Dorado_DesktopApp.Controller;
using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.View.ClientesView
{
    public partial class FormClientes : Form
    {
        HotelDoradoContext context;
        ClienteController controller;
        public FormClientes()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new ClienteController(context);



            mostrarClientes();
        }
        private void mostrarClientes()
        {
            var listaClientes = controller.GetAllGuests();
            tbClientes.Rows.Clear();
            foreach (var i in listaClientes)
            {
                tbClientes.Rows.Add(i.ClienteId, i.Nombre, i.Apellido, i.Email, i.Telefono, "", "");
            }

        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbClientes.Columns[e.ColumnIndex].Name == "Borrar")
            {
                //int id = (int)tbClientes.Rows[indice].Cells["Id"].Value;
                MessageBox.Show("Presionastes borrar");
                //  eliminarEmpleado(id);
            }
            if (tbClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                MessageBox.Show("Presionastes editar");
                /*
                txtId.Text = tbClientes.Rows[indice].Cells["Id"].Value.ToString();
                txtNumeroCedula.Text = tbClientes.Rows[indice].Cells["Cedula"].Value.ToString();
                txtNombre.Text = tbClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                txtApellido.Text = tbClientes.Rows[indice].Cells["Apellido"].Value.ToString();
                char sexo = Convert.ToChar(tbClientes.Rows[indice].Cells["Sexo"].Value);
                if (sexo == 'M')
                {
                    cbxSexo.SelectedIndex = 0;
                }
                else if (sexo == 'F')
                {
                    cbxSexo.SelectedIndex = 1;
                }
                txtTelefono.Text = tbClientes.Rows[indice].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = tbClientes.Rows[indice].Cells["Direccion"].Value.ToString();
                txtCorreo.Text = tbClientes.Rows[indice].Cells["Correo"].Value.ToString();
                txtCargo.Text = tbClientes.Rows[indice].Cells["Cargo"].Value.ToString();
                txtSalario.Text = tbClientes.Rows[indice].Cells["Salario"].Value.ToString();
                dtNacimiento.Value = Convert.ToDateTime(tbClientes.Rows[indice].Cells["Nacimiento"].Value);
                */
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente form = new FormRegistrarCliente();
            form.ShowDialog();
            mostrarClientes();
        }

        private void btnNuevoRegistro(object sender, EventArgs e)
        {

        }
    }
}
