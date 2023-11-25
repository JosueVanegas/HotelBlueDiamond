using Hotel.Controllers;
using Hotel.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Gestion.Salidas
{
    public partial class SalidaViewRegister : Form
    {
        HotelContext context;
        Reserva reserva;
        int? HabitacionID;
        int diasTranscurridos = 0;
        public SalidaViewRegister(int? HabitacionID)
        {
            InitializeComponent();
            context = new HotelContext();
            mostrarDatos(HabitacionID);
            this.TransparencyKey = Color.Empty;
            this.HabitacionID = HabitacionID;
        }
        private void mostrarServicio(int? id)
        {
            var controller = new RecepcionController(context);
            var lista = controller.GetPedidoByHabitacion(id);
            bool? estadoPago = false;
            Decimal subTotalTabla = 0, totalPagados = 0, totalPendientes = 0;
            foreach (var i in lista)
            {
                estadoPago = i.Estado;
                foreach (var j in i.DetallePedidos)
                {

                    var estado = "";
                    if (estadoPago == true)
                    {
                        estado = "pagado";
                        totalPagados += Convert.ToDecimal(j.Cantidad * j.Producto.Precio);
                    }
                    if (estadoPago == false)
                    {
                        estado = "pendiente";
                        totalPendientes += Convert.ToDecimal(j.Cantidad * j.Producto.Precio);
                    }
                    subTotalTabla = Convert.ToDecimal(j.Cantidad * j.Producto.Precio);
                    tbDetallles.Rows.Add(j.ProductoId, j.Producto.Descripcion, j.Producto.Precio, j.Cantidad, subTotalTabla, estado, "", "");

                }
            }
            txtServicioPagado.Text = totalPagados.ToString("0.00");
            txtTotalServicio.Text = totalPendientes.ToString("0.00");
        }
        private void mostrarDatos(int? id)
        {
            try
            {
                var controller = new RecepcionController(context);
                reserva = controller.GetReservaByHabitacion(id);
                if (reserva != null)
                {
                    txtNombre.Text = reserva.Cliente.Nombre;
                    txtApellido.Text = reserva.Cliente.Apellido;
                    txtCedula.Text = reserva.Cliente.Cedula;
                    txtCantidadHuespedes.Text = reserva.CantidadPersonas.ToString();
                    dtpEntrada.Text = reserva.FechaEntrada.ToString();
                    dtpSalida.Text = DateTime.Now.ToString("G");
                    txtAdelanto.Text = reserva.Adelanto.ToString();
                    txtNumero.Text = reserva.Habitacion.Codigo;
                    txtCategoria.Text = reserva.Habitacion.CategoriaHabitacion.Descripcion;
                    txtPrecioPH.Text = reserva.Habitacion.PrecioPh.ToString();
                    txtPiso.Text = reserva.Habitacion.Piso.Descripcion;
                    txtDetalles.Text = reserva.Habitacion.Detalles;
                    txtExtras.Text = reserva.Habitacion.Extras;
                    TimeSpan? diferencia = DateTime.Now - reserva.FechaEntrada;
                    diasTranscurridos = diferencia.Value.Days;
                    txtNoches.Text = diasTranscurridos.ToString();
                    var totalHabitacion = diasTranscurridos * reserva.Habitacion.PrecioPh;
                    txtTotalHabitacion.Text = totalHabitacion.ToString();
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
                decimal totalNoches = Convert.ToDecimal(txtPrecioPH.Text) * diasTranscurridos;
                decimal totalServicio = Convert.ToDecimal(txtTotalServicio.Text)+Convert.ToDecimal(txtServicioPagado.Text);
                decimal cargoRoturas = Convert.ToDecimal(txtCargoRoturas.Text);
                decimal adelanto = Convert.ToDecimal(txtAdelanto.Text);
                if(totalNoches == 0)
                {
                    totalNoches = Convert.ToDecimal(txtPrecioPH.Text);
                }
                decimal subTotal = (totalNoches + totalServicio + cargoRoturas);
                if (adelanto >= subTotal )
                {
                    subTotal = 0;
                }
                else
                {
                 subTotal =   (totalNoches + totalServicio + cargoRoturas) - adelanto;
                }
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
                if (txtPago.Text != "" && txtPago.Text != "0")
                {
                    if (MessageBox.Show("Estas apunto de finalizar la reservación,¿Desea finalizarla?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    
                            calculosTotales();
                            context = new HotelContext();
                            var controller = new RecepcionController(context);
                            Reserva r = new Reserva
                            {
                                ReservaId = reserva.ReservaId,
                                ClienteId = reserva.ClienteId,
                                HabitacionId = reserva.HabitacionId,
                                EmpleadoId = reserva.EmpleadoId,
                                FechaEntrada = reserva.FechaEntrada,
                                FechaSalida = DateTime.Now,
                                Adelanto = Convert.ToDecimal(txtAdelanto.Text),
                                CantidadPersonas = reserva.CantidadPersonas,
                                TotalDaños = Convert.ToDecimal(txtCargoRoturas.Text),
                                FechaRegistro = DateTime.Now,
                                Finalizada = true,
                                Total = Convert.ToDecimal(txtTotal.Text),
                                HorasReservadas = diasTranscurridos,
                            };
                            controller.UpdateReservaObject(r);
                        
                        using(var cont = new HotelContext())
                        {
                            var control = new RecepcionController(cont);
                            control.UpdateServices(reserva.ReservaId);
                        }
                        using(var cont = new HotelContext())
                        {
                            var control = new HabitacionesController(cont);
                            control.SetState(HabitacionID, 1);
                        }
                        MessageBox.Show("Reservación terminada exitosamente", "Reservación concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese el pago del cliente", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }
            if (textBox.Text.Length >= 10 || (textBox.Text.Contains(".") && textBox.Text.Split('.')[1].Length >= 2) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
