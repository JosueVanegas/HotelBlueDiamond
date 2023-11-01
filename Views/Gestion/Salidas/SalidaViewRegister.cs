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
            this.TransparencyKey = Color.Empty;
        }
        private void mostrarDatos(int id)
        {
            try
            {
                var controller = new RecepcionController(context);
                var reserva = controller.GetReservaByHabitacion(id);
                if (reserva != null)
                {
                    //informacion del cliente
                    txtNombre.Text = reserva.Cliente.Nombre;
                    txtApellido.Text = reserva.Cliente.Apellido;
                    txtCedula.Text = reserva.Cliente.Cedula;
                    txtCantidadHuespedes.Text = reserva.CantidadPersonas.ToString();
                    //infromacion de la reserva
                    dtpEntrada.Text = reserva.FechaEntrada.ToString();
                    dtpSalida.Text = reserva.FechaSalida.ToString();
                    txtAdelanto.Text = reserva.Adelanto.ToString();
                    //informacion de la habitacion
                    txtNumero.Text = reserva.Habitacion.Codigo;
                    txtCategoria.Text = reserva.Habitacion.CategoriaHabitacion.Descripcion;




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
