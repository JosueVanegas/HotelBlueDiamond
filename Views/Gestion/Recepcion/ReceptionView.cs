﻿using Hotel_Dorado_DesktopApp.Controller;
using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.View.ClientesView;
using Hotel_Dorado_DesktopApp.Views.GestionView.Recepcion;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.GestionView
{
    public partial class ReceptionView : Form
    {
        HotelDoradoContext context;
        Habitacion habitacion;
        public ReceptionView(Habitacion habitacion)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            context = new HotelDoradoContext();
            mostrarClientes();
            dtSalida.Value = DateTime.Now.AddDays(1);
            dtSalida.MinDate = DateTime.Now.AddDays(1);
            mostrarDetallesHabitacion();
            this.TransparencyKey = Color.Empty;
        }
        private void mostrarClientes()
        {
            cbxCliente.DataSource = new ClienteController(context).GetAllObjects();
            cbxCliente.DisplayMember = "Cedula";
        }
        private void mostrarDetallesHabitacion()
        {
            txtCapacidad.Text = habitacion.CategoriaHabitacion.Capacidad.ToString();
            txtCantidad.Maximum = Convert.ToInt32(txtCapacidad.Text);
            txtDetalles.Text = habitacion.Detalles;
            txtExtras.Text = habitacion.Extras;
            txtCategoria.Text = habitacion.CategoriaHabitacion.Descripcion;
            txtEstado.Text = habitacion.Estado.Descripcion;
            txtNumero.Text = habitacion.Codigo;
            txtPrecioPH.Text = habitacion.PrecioPh.ToString();
            txtPiso.Text = habitacion.Piso.Descripcion;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtNumero.Text != "")
            {
                try
                {
                    var recepcionController = new RecepcionController(context);
                    var habitacionController = new HabitacionesController(context);
                    var cliente = (Cliente)cbxCliente.SelectedItem;
                    Reserva recepcion = new Reserva
                    {
                        ClienteId = cliente.ClienteId,
                        HabitacionId = habitacion.HabitacionId,
                        EmpleadoId = 1,
                        FechaSalida = dtSalida.Value,
                        FechaEntrada = DateTime.Now,
                        Adelanto = Convert.ToDecimal(txtAdelanto.Text),
                        FechaRegistro = DateTime.Now,
                        CantidadPersonas = Convert.ToInt32(txtCantidad.Text),
                        Finalizada = false,
                    };
                    recepcionController.AddObject(recepcion);

                    MessageBox.Show("Proceso de recervación de habitación finalizado exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proceso de recervación fallido " + ex.Message, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteViewRegister form = new ClienteViewRegister(null);
            form.ShowDialog();
            mostrarClientes();
        }
    }
}