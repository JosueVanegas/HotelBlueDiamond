using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using ReaLTaiizor.Controls;
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
        public ReservaViewResume()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            mostrarHabitaciones();
        }
        private void mostrarHabitaciones()
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
                        if (i.Estado.EstadoId == 2)
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

                            System.Windows.Forms.Button verDetalles;
                            verDetalles = new System.Windows.Forms.Button
                            {
                                Text = "Ver detalles",
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
                                    break;
                                case 2:
                                    label2.BackColor = Color.Red;
                                    label2.ForeColor = Color.White;
                                    break;
                                case 3:
                                    label2.BackColor = Color.Yellow;
                                    label2.ForeColor = Color.Black;
                                    break;
                                case 4:
                                    label2.BackColor = Color.Orange;
                                    label2.ForeColor = Color.Black;
                                    break;
                                default:
                                    break;
                            }
                            verDetalles.Click += (s, e) =>
                            {
                                MessageBox.Show("Esta habitación esta "+i.Estado.Descripcion);
                            };
                            panel.Controls.Add(verDetalles);
                            this.panelContenedor.Controls.Add(panel);
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
    }
}
