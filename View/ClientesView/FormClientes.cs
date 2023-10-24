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
            context = new HotelDoradoContext();
            controller = new ClienteController(context);
            var listaClientes = controller.GetAllObjects();
            tbClientes.Rows.Clear();
            foreach (var i in listaClientes)
            {
                tbClientes.Rows.Add(i.ClienteId, i.Cedula, i.Nombre, i.Apellido, i.Email, i.Telefono, "", "");
            }

        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbClientes.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbClientes.Rows[indice].Cells["Id"].Value;
                    
                    if(MessageBox.Show("¿Esta seguro de eliminar al cliente seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarClientes();
                        MessageBox.Show("Cliente eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                Cliente cliente = new Cliente
                {
                    ClienteId = Convert.ToInt32(tbClientes.Rows[indice].Cells["Id"].Value),
                    Cedula = tbClientes.Rows[indice].Cells["Cedula"].Value.ToString(),
                    Nombre = tbClientes.Rows[indice].Cells["Nombre"].Value.ToString(),
                    Apellido = tbClientes.Rows[indice].Cells["Apellido"].Value.ToString(),
                    Telefono = tbClientes.Rows[indice].Cells["Telefono"].Value.ToString(),
                    Email = tbClientes.Rows[indice].Cells["Email"].Value.ToString(),
                };
                FormRegistrarCliente form = new FormRegistrarCliente(cliente);
                form.ShowDialog();
                mostrarClientes();
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
        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            FormRegistrarCliente form = new FormRegistrarCliente(null);
            form.ShowDialog();
            mostrarClientes();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*
 *  private void InitializeCarrusel()
        {
            int itemWidth = 200;
            int itemHeight = 250;

            Producto[] products = new Producto[]
            {
        new Producto { Descripcion = "Agua"},
        new Producto { Descripcion = "Coca-cola"},
         new Producto { Descripcion = "rer"},
        new Producto { Descripcion = "Csdgg"},
         new Producto { Descripcion = "pepino"},
        new Producto { Descripcion = "Cebolla"},
         new Producto { Descripcion = "ajo"},
        new Producto { Descripcion = "botella"},
         new Producto { Descripcion = "leche"},
        new Producto { Descripcion = "Manis"},
         new Producto { Descripcion = "jugo de naranja"},
        new Producto { Descripcion = "Cerveza"},
         new Producto { Descripcion = "frost"},
        new Producto { Descripcion = "tpña"}
                // Agrega más productos aquí
            };

            int index = 0;
            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = itemWidth,
                    Height = itemHeight,
                    BorderStyle = BorderStyle.Fixed3D,
                    Left = index * itemWidth,
                };

                Label label = new Label
                {
                    Text = product.Descripcion,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                productPanel.Controls.Add(label);

                Button buyButton = new Button
                {
                    Text = "Comprar",
                    Dock = DockStyle.Bottom,
                    Size = new Size(itemWidth,50),
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.White
                };
                buyButton.Click += (s, e) => MessageBox.Show($"Comprado {product.Descripcion}");
                productPanel.Controls.Add(buyButton);

                this.panel1.Controls.Add(productPanel);

                index++;
            }
        }
 */