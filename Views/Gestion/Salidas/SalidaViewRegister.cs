using Hotel_Dorado_DesktopApp.Controllers;
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

namespace Hotel_Dorado_DesktopApp.Views.Gestion.Salidas
{
    public partial class SalidaViewRegister : Form
    {
        HotelDoradoContext context;
        Reserva reserva;
        public SalidaViewRegister(int HabitacionID)
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            mostrarDatos(HabitacionID);
            timer.Start();
        }
        private void mostrarDatos(int id)
        {
            try
            {
                var controller = new RecepcionController(context);
                var reserva = controller.GetObjectByIdQuery(id);
                if (reserva != null)
                {
                    txtNombre.Text = reserva.Cliente.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            dtpSalida.Text = DateTime.Now.ToString("G");
        }
    }
}
