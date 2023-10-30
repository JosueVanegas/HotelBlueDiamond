using Hotel_Dorado_DesktopApp.Controller;
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
        public ReceptionView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            this.horaEntrada.Start();
            mostrarCarrucel();
            mostrarClientes();
        }
        private void mostrarClientes()
        {
            cbxCliente.DataSource = new ClienteController(context).GetAllObjects();
            cbxCliente.DisplayMember = "Nombre";
        }
        private void mostrarCarrucel()
        {
            try
            {
                int itemWidth = 180;
                int itemHeight = 170;
                var habitaciones = new HabitacionesController(context).GetAllObjects();

                if (habitaciones.Count != 0)
                {
                    int index = 0;
                    foreach (var i in habitaciones)
                    {
                        if (i.Estado.EstadoId == 1)
                        {
                            ParrotGradientPanel panel = new ParrotGradientPanel
                            {
                                PrimerColor = Color.White,
                                BottomLeft = Color.LightGray,
                                TopLeft = Color.LightGray,
                                TopRight = Color.White,
                                BottomRight = Color.Beige,
                                Width = itemWidth,
                                Height = itemHeight,
                                BorderStyle = BorderStyle.FixedSingle,
                                Left = index * itemWidth,
                            };
                            Label label2 = new Label
                            {
                                ForeColor = Color.White,
                                Text = "Estado: \n" + i.Estado.Descripcion,
                                Dock = DockStyle.Top,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Height = 60,
                                BackColor = Color.Green
                            };
                            panel.Controls.Add(label2);

                            Label label1 = new Label
                            {
                                ForeColor = Color.FromArgb(0, 51, 102),
                                Text = "Habitación numero: \n" + i.Codigo,
                                Dock = DockStyle.Top,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Height = 60,
                                BackColor = Color.White
                            };
                            panel.Controls.Add(label1);

                            System.Windows.Forms.Button verDetalles;
                            verDetalles = new System.Windows.Forms.Button
                            {
                                Text = "Ver detalles",
                                Dock = DockStyle.Bottom,
                                Size = new Size(itemWidth, 40),
                                BackColor = Color.FromArgb(0, 51, 102),
                                ForeColor = Color.White
                            };
                            verDetalles.Click += (s, e) =>
                            {
                                txtIdHabitacion.Text = i.HabitacionId.ToString();
                                txtNumero.Text = i.Codigo;
                                txtCategoria.Text = i.CategoriaHabitacion.Descripcion;
                                txtCapacidad.Text = i.CategoriaHabitacion.Capacidad.ToString();
                                txtPrecioPH.Text = i.PrecioPh.ToString();
                                txtDetalles.Text = i.Detalles;
                                txtExtras.Text = i.Extras;
                                txtEstado.Text = i.Estado.Descripcion;
                                txtPiso.Text = i.Piso.Descripcion;
                                if (i.Estado.EstadoId == 1)
                                {
                                    btnReservar.Enabled = true;
                                }
                            };
                            panel.Controls.Add(verDetalles);
                            this.panelCarrusel.Controls.Add(panel);
                            index++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay habitaciones registradas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (txtCantidadHuespedes.Text != "" && txtNumero.Text != "")
            {
                try
                {
                    var recepcionController = new RecepcionController(context);
                    var habitacionController = new HabitacionesController(context);
                    var cliente = (Cliente)cbxCliente.SelectedItem;
                    Reserva recepcion = new Reserva
                    {
                        ClienteId = cliente.ClienteId,
                        HabitacionId = Convert.ToInt32(txtIdHabitacion.Text),
                        EmpleadoId = 1,
                        FechaEntrada = DateTime.Now,
                        Adelanto = Convert.ToDecimal(txtAdelanto.Text),
                        FechaRegistro = DateTime.Now,
                        CantidadPersonas = Convert.ToInt32(txtCantidadHuespedes.Text),
                        Finalizada = false,
                    };
                    recepcionController.AddObject(recepcion);

                    MessageBox.Show("Proceso de recervación de habitación finalizado exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proceso de recervación fallido "+ex.Message, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void horaEntrada_Tick(object sender, EventArgs e)
        {
            dtpEntrada.Text = DateTime.Now.ToString("G");
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteViewRegister form = new ClienteViewRegister(null);
            form.ShowDialog();
            mostrarClientes();
        }
    }
}
