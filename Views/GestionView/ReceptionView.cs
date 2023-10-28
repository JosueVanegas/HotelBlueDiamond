using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
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
        RecepcionController recepcionController;
        public ReceptionView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            recepcionController = new RecepcionController(context);
            mostrarRecepciones();
            for (int i = 0; i < 16; i++)
            {
                mostrarCarrucel();
            }

        }
        private void mostrarRecepciones()
        {

        }
        private void mostrarCarrucel()
        {
            try
            {
                int itemWidth = 200;
                int itemHeight = 250;
                var habitaciones = new HabitacionesController(context).GetAllObjects();

                if (habitaciones.Count != 0)
                {
                    int index = 0;
                    foreach (var i in habitaciones)
                    {
                        ParrotGradientPanel panel = new ParrotGradientPanel
                        {
                            PrimerColor = Color.White,
                            BottomLeft = Color.LightBlue,
                            TopLeft = Color.Blue,
                            TopRight = Color.Green,
                            BottomRight = Color.LightGreen,
                            Width = itemWidth,
                            Height = itemHeight,
                            BorderStyle = BorderStyle.FixedSingle,
                            Left = index * itemWidth,
                        };
                        Label label2 = new Label
                        {
                            ForeColor = Color.Black,
                            Text = "Estado: " + i.Estado.Descripcion,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Height = 60,
                            BackColor = Color.Transparent
                        };
                        panel.Controls.Add(label2);

                        Label label1 = new Label
                        {
                            ForeColor = Color.Black,
                            Text = "Habitación numero: " + i.Codigo,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Height = 60,
                            BackColor = Color.Transparent
                        };
                        panel.Controls.Add(label1);

                        System.Windows.Forms.Button verDetalles;
                        verDetalles = new System.Windows.Forms.Button
                        {
                            Text = "Ver detalles",
                            Dock = DockStyle.Bottom,
                            Size = new Size(itemWidth, 40),
                            BackColor = Color.Green,
                            ForeColor = Color.Black
                        };
                        switch (i.Estado.EstadoId)
                        {
                            case 1:
                                verDetalles.BackColor = Color.Green;
                                break;
                            case 2:
                                verDetalles.BackColor = Color.Red;
                                break;
                            case 3:
                                verDetalles.BackColor = Color.Yellow;
                                break;
                            case 4:
                                verDetalles.BackColor = Color.Orange;
                                break;
                            default:
                                break;
                        }
                        verDetalles.Click += (s, e) =>
                        {
                            txtNumero.Text = i.Codigo;
                            txtCategoria.Text = i.CategoriaHabitacion.Descripcion;
                            txtCapacidad.Text = i.CategoriaHabitacion.Capacidad.ToString();
                            txtPrecioPH.Text = i.PrecioPh.ToString();
                            txtDetalles.Text = i.Detalles;
                            txtExtras.Text = i.Extras;
                            txtEstado.Text = i.Estado.Descripcion;
                            txtPiso.Text = i.Piso.Descripcion;
                        };
                        panel.Controls.Add(verDetalles);
                        this.panelCarrusel.Controls.Add(panel);
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

        private void txtReservar_Click(object sender, EventArgs e)
        {

        }
    }
}
