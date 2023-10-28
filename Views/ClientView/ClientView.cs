﻿using Hotel_Dorado_DesktopApp.Controller;
using Hotel_Dorado_DesktopApp.Models;
using ReaLTaiizor.Controls;
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
    public partial class ClientView : Form
    {
        HotelDoradoContext context;
        ClienteController controller;
        public ClientView()
        {

            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new ClienteController(context);
            mostrarClientes();
            tbClientes.Left = (panelContenedor.Width - tbClientes.Width) / 2;
            tbClientes.Top = (panelContenedor.Height - tbClientes.Height) / 2;
            btnRegistrar.Left = (panel1.Width - btnRegistrar.Width) / 2;
        }
        private void mostrarClientes()
        {
            Cursor = Cursors.WaitCursor;
            context = new HotelDoradoContext();
            controller = new ClienteController(context);
            var listaClientes = controller.GetAllObjects();
            tbClientes.Rows.Clear();
            foreach (var i in listaClientes)
            {
                tbClientes.Rows.Add(i.ClienteId, i.Cedula, i.Nombre, i.Apellido, i.Email, i.Telefono, "", "");
            }
            Cursor = Cursors.Default;
        }
        private void cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (tbClientes.Columns[e.ColumnIndex].Name == "Borrar")
            {
                try
                {
                    int id = (int)tbClientes.Rows[indice].Cells["Id"].Value;

                    if (MessageBox.Show("¿Esta seguro de eliminar al cliente seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        controller.DeleteObject(id);
                        mostrarClientes();
                        MessageBox.Show("Cliente eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AdmClientView form = new AdmClientView(cliente);
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AdmClientView form = new AdmClientView(null);
            form.ShowDialog();
            mostrarClientes();
        }
    }
}