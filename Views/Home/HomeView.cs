﻿using Hotel.Models;
using Hotel.View.ClientesView;
using Hotel.Views.Ayudas;
using Hotel.Views.EmpleadosAsignaciones.Asignaciones;
using Hotel.Views.EmpleadosAsignaciones.Personal;
using Hotel.Views.GestionView;
using Hotel.Views.GestionView.Recepcion;
using Hotel.Views.Habitaciones;
using Hotel.Views.Home;
using Hotel.Views.Pedidos.Productos;
using Hotel.Views.Pedidos.Proveedores;
using Hotel.Views.Pedidos.Ventas;
using Hotel.Views.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Home
{
    public partial class HomeView : Form
    {
        Usuario usuario;
        public HomeView(Usuario usuario)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.usuario = usuario;
            llenarDatosUsuario();
            Reloj.Start();
            this.MinimumSize = new Size(600, 800);
            this.TransparencyKey = Color.Empty;
            abrirFormulario(new DashBoardView());
            this.Cursor = Cursors.Default;
        }
        private void llenarDatosUsuario()
        {
            if (usuario != null)
            {
                string datos = $"|  Nombre de usuario: {usuario.Usuario1}   |   " +
                    $"|  Persona asignada: {usuario.Empleado.Nombre + " " + usuario.Empleado.Apellido}   |   Rol de usuario: {usuario.Rol.Descripcion}    |   ";
                lblUsuario.Text = datos;
            }
        }
        private void HomeView_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
            {
                item.DropDownOpened += Item_DropDownOpened;
                item.DropDownClosed += Item_DropDownClosed;
            }
        }
        private void abrirFormulario(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ClientView());
        }
        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new HabitacionesView());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CategoriasHabitacionView());
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString();
        }
        private void Item_DropDownOpened(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in Menu.Items)
            {
                item.BackColor = Color.Transparent;
            }
            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            if (selectedItem != null)
            {
                selectedItem.BackColor = Color.LightBlue;
                selectedItem.ForeColor = Color.Black;
            }
        }

        private void Item_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem closedItem = sender as ToolStripMenuItem;
            if (closedItem != null)
            {
                closedItem.BackColor = Color.Transparent;
                closedItem.ForeColor = Color.Beige;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new EmpleadosView());
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CargosView());
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AsignacionView());
        }

        private void btnAyudaMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AyudaView());
        }

        private void btnHospedajeMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ReservaViewResume(this.usuario));
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ProductoView());
        }

        private void btnUsuariosMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new UsuariosView());
        }

        private void btnInicioMenu_Click(object sender, EventArgs e)
        {
            abrirFormulario(new DashBoardView());
        }

        private void categoriasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CategoriasView());
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar de usuario?", "Cambiar de usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ProveedorView());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new VentaView());
        }
    }
}