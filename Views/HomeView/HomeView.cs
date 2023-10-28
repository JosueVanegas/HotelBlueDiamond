using Hotel_Dorado_DesktopApp.View.ClientesView;
using Hotel_Dorado_DesktopApp.Views.GestionView;
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
            abrirFormulario(new ReceptionView());
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
        }
    }
}
