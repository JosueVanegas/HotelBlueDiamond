using Hotel_Dorado_DesktopApp.View.ClientesView;
using Hotel_Dorado_DesktopApp.Views.GestionView;
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
            abrirFormulario(new DashBoardView());
        }
        private void abrirFormulario(Form formHijo)
        {
            // Cerramos cualquier formulario que esté abierto en el contenedor
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            // Preparamos el nuevo formulario
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            // Añadimos el nuevo formulario al contenedor y lo mostramos
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new DashBoardView());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ReceptionView());
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnPisos_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

        }
    }
}
