using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.Views.Gestion.Salidas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.GestionView.Recepcion
{
    public partial class ReservaViewResume : Form
    {
        HotelDoradoContext context;
        Usuario usuario;
        public ReservaViewResume(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            context = new HotelDoradoContext();
            mostrarHabitaciones();
        }
        private void mostrarHabitaciones()
        {
            try
            {
                int itemWidth = 180;
                int itemHeight = 170;
                context = new HotelDoradoContext();
                var habitaciones = new HabitacionesController(context).GetAllObjects();
                panelContenedor.Controls.Clear();
                if (habitaciones.Count != 0)
                {
                    int index = 0;
                    foreach (var i in habitaciones)
                    {
                        Panel panel = new Panel
                        {
                            Width = itemWidth,
                            Height = itemHeight,
                            BorderStyle = BorderStyle.FixedSingle,
                            Left = index * itemWidth,
                        };
                        Label label2 = new Label
                        {
                            ForeColor = Color.FromArgb(0, 51, 102),
                            Text = "Estado: \n" + i.Estado.Descripcion,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Height = 60,
                            BackColor = Color.Transparent
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

                        System.Windows.Forms.Button boton;
                        boton = new System.Windows.Forms.Button
                        {
                            Dock = DockStyle.Bottom,
                            Size = new Size(itemWidth, 40),
                            BackColor = Color.FromArgb(0, 51, 102),
                            ForeColor = Color.White
                        };
                        switch (i.Estado.EstadoId)
                        {
                            case 1:
                                label2.BackColor = Color.Green;
                                label2.ForeColor = Color.White;
                                boton.Text = "Reservar";
                                boton.Click += (s, e) =>
                                {
                                    ReceptionView form = new ReceptionView(i,usuario);
                                    form.ShowDialog();
                                    mostrarHabitaciones();
                                };
                                break;
                            case 2:
                                label2.BackColor = Color.Red;
                                label2.ForeColor = Color.White;
                                boton.Text = "Concluir reservación";
                                boton.Click += (s, e) =>
                                {
                                    SalidaViewRegister form = new SalidaViewRegister(i.HabitacionId);
                                    form.ShowDialog();
                                    mostrarHabitaciones();
                                };
                                break;
                            case 3:
                                label2.BackColor = Color.Yellow;
                                label2.ForeColor = Color.Black;
                                boton.Click += (s, e) =>
                                {
                                };
                                break;
                            case 4:
                                label2.BackColor = Color.Orange;
                                label2.ForeColor = Color.Black;
                                boton.Click += (s, e) =>
                                {
                                };
                                break;
                            default:
                                break;
                        }

                        panel.Controls.Add(boton);
                        this.panelContenedor.Controls.Add(panel);
                        index++;
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
    }
}
