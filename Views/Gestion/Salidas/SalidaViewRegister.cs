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
        int HabitacionID;
        public SalidaViewRegister(int HabitacionID)
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            mostrarDatos(HabitacionID);
            this.TransparencyKey = Color.Empty;
            this.HabitacionID = HabitacionID;
        }
        private void mostrarServicio(int id)
        {
            var controller = new RecepcionController(context);
            var lista = controller.GetPedidoByHabitacion(id);
            foreach ( var item in lista )
            {
            }
        }
        private void mostrarDatos(int id)
        {
            try
            {
                var controller = new RecepcionController(context);
                reserva = controller.GetReservaByHabitacion(id);
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
                    txtPrecioPH.Text = reserva.Habitacion.PrecioPh.ToString();
                    txtPiso.Text = reserva.Habitacion.Piso.Descripcion;
                    txtDetalles.Text = reserva.Habitacion.Detalles;
                    txtExtras.Text = reserva.Habitacion.Extras;
                    //informacion del servicio a la habitación
                    mostrarServicio(id);
                    calculosTotales();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ninguna reservación para esta habitación", "No encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void calculosTotales()
        {
            try
            {
                decimal precioNoche = Convert.ToDecimal(txtPrecioPH.Text);
                decimal totalServicio = Convert.ToDecimal(txtTotalServicio.Text);
                decimal cargoRoturas = Convert.ToDecimal(txtCargoRoturas.Text);
                decimal cargoPorTiempo = Convert.ToDecimal(txtCargoEstancia.Text);
                decimal adelanto = Convert.ToDecimal(txtAdelanto.Text);

                decimal subTotal = (precioNoche + totalServicio + cargoRoturas + cargoPorTiempo) - adelanto;
                txtTotal.Text = subTotal.ToString("0.00");
                decimal pago = Convert.ToDecimal(txtPago.Text);
                if (pago != 0)
                {
                    if (pago >= subTotal)
                    {
                        decimal cambio = pago - subTotal;
                        txtCambio.Text = cambio.ToString("0.00");
                    }
                }
            }
            catch (Exception ex)
            {
            }

        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas apunto de finalizar la reservación,¿Desea finalizarla?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    calculosTotales();
                    var controller = new RecepcionController(context);
                    Reserva r = new Reserva
                    {
                        ClienteId = reserva.ClienteId,
                        HabitacionId = reserva.HabitacionId,
                        EmpleadoId = reserva.EmpleadoId,
                        FechaEntrada = reserva.FechaEntrada,
                        FechaSalida = reserva.FechaSalida,
                        Adelanto = Convert.ToDecimal(txtAdelanto.Text),
                        CantidadPersonas = reserva.CantidadPersonas,
                        TotalDaños = Convert.ToDecimal(txtCargoRoturas.Text),
                        FechaRegistro = DateTime.Now,
                        Finalizada = true,
                        Total = Convert.ToDecimal(txtTotal.Text),
                    };
                    controller.UpdateObject(r);
                    controller.UpdateServices(reserva.ReservaId);
                    controller.SetState(HabitacionID, 1);
                    //con estes codigo deberia digo yo de actualizar la reservacion y ponerla nula poner la habitacion en disponible y colocar como cancelado cualquier servicio a la habitacion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCargoEstancia_TextChanged(object sender, EventArgs e)
        {
            calculosTotales();
        }

        private void txtCargoRoturas_TextChanged(object sender, EventArgs e)
        {
            calculosTotales();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            calculosTotales();
        }
        private void ValidarDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (e.KeyChar == '.' && textBox.Text.Length == 0)
            {
                e.Handled = true; // No permite un punto al comienzo.
                return;
            }

            // Verifica si el carácter presionado es un dígito, un punto o la tecla de retroceso (borrar).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // No permite el carácter ingresado.
                return;
            }

            // Si ya hay un punto en el TextBox, no permite otro.
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            // Verifica si el TextBox ya tiene 10 caracteres o si se ingresan más de 2 decimales.
            if (textBox.Text.Length >= 10 || (textBox.Text.Contains(".") && textBox.Text.Split('.')[1].Length >= 2) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
