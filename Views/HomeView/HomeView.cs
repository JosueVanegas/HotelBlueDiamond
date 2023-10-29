﻿using Hotel_Dorado_DesktopApp.View.ClientesView;
using Hotel_Dorado_DesktopApp.Views.GestionView;
using Hotel_Dorado_DesktopApp.Views.GestionView.Recepcion;
using Hotel_Dorado_DesktopApp.Views.Habitaciones;
using Hotel_Dorado_DesktopApp.Views.HomeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            Reloj.Start();
            abrirFormulario(new DashBoardView());
        }
        private void HomeView_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in Menu.Items)
            {
                item.DropDownOpened += Item_DropDownOpened;
                item.DropDownClosed += Item_DropDownClosed; // Agregar este manejador de evento
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
        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ClientView());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Reloj.Stop();
            this.Close();
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ReservaViewResume());
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new HabitacionesView());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CategoriasHabitacionView());
        }

        private void btnInicioInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new DashBoardView());
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString();
        }
        private void Item_DropDownOpened(object sender, EventArgs e)
        {
            // Primero, restablecer el color de fondo de todos los ítems a su color por defecto
            foreach (ToolStripItem item in Menu.Items)
            {
                item.BackColor = Color.Transparent;
            }

            // Cambiar el color de fondo del ítem seleccionado
            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            if (selectedItem != null)
            {
                selectedItem.BackColor = Color.LightBlue;
                selectedItem.ForeColor = Color.Black;
            }
        }

        // Método para manejar el evento DropDownClosed
        private void Item_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem closedItem = sender as ToolStripMenuItem;
            if (closedItem != null)
            {
                closedItem.BackColor = Color.Transparent;
                closedItem.ForeColor = Color.Beige; // Asumiendo que este es tu color por defecto
            }
        }

        private void btnRecepcionSalida_Click(object sender, EventArgs e)
        {
            abrirFormulario(new SalidaView());
        }
    }
}
