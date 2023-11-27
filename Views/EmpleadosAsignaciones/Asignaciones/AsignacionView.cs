using Hotel.Controllers;
using Hotel.Models;
using Hotel.Views.Gestion.Salidas;
using Hotel.Views.GestionView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.EmpleadosAsignaciones.Asignaciones
{
    public partial class AsignacionView : Form
    {
        public AsignacionView()
        {
            InitializeComponent();
            mostrarHabitaciones();
        }
        private void mostrarHabitaciones()
        {
            try
            {
                using (var context = new HotelContext())
                {
                    int itemWidth = 180;
                    int itemHeight = 170;
                    var habitaciones = new HabitacionesController(context).GetAllObjects();
                    panelCarrusel.Controls.Clear();
                    if (habitaciones.Count != 0)
                    {
                        int index = 0;
                        foreach (var i in habitaciones)
                        {
                            if(i.EstadoId != 2)
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
                                    ForeColor = Color.Black,
                                    Text = "Categoria: \n" + i.CategoriaHabitacion.Descripcion + "\n Piso: " + i.Piso.Descripcion,
                                    Dock = DockStyle.Top,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Height = 60,
                                    BackColor = Color.LightGray
                                };
                                panel.Controls.Add(label2);

                                Label lblDetalle = new Label
                                {
                                    ForeColor = Color.Black,
                                    Text = "Habitación numero: \n" + i.Codigo,
                                    Dock = DockStyle.Top,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Height = 30,
                                    BackColor = Color.White
                                };
                                Label lblEstado = new Label
                                {
                                    ForeColor = Color.Black,
                                    Text = "Estado: \n" + i.Estado.Descripcion,
                                    Dock = DockStyle.Top,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Height = 30,
                                    BackColor = Color.White
                                };
                                panel.Controls.Add(lblEstado);
                                panel.Controls.Add(lblDetalle);

                                System.Windows.Forms.Button boton;
                                boton = new System.Windows.Forms.Button
                                {
                                    Cursor = Cursors.Hand,
                                    Dock = DockStyle.Bottom,
                                    Size = new Size(itemWidth, 40),
                                    ForeColor = Color.Black
                                };
                               
                                switch (i.EstadoId)
                                {
                                    case 1:
                                        boton.Text = "Asignar tarea";
                                        lblEstado.BackColor = Color.LightGreen;
                                        boton.BackColor = Color.LightGreen;
                                        boton.Click += (s, e) =>
                                        {
                                            var form = new AsignacionViewRegister(i);
                                            form.ShowDialog();
                                            mostrarHabitaciones();
                                        };
                                        break;
                                    case 3:
                                        boton.Text = "Finalizar limpieza";
                                        lblEstado.BackColor = Color.Yellow;
                                        boton.BackColor = Color.Yellow;
                                        boton.Click += (s, e) =>
                                        {
                                            var form = new AsignacionViewRegister(i);
                                            form.ShowDialog();
                                            mostrarHabitaciones();
                                        };
                                        break;
                                    case 4:
                                        boton.Text = "Finalizar mantenimiento";
                                        lblEstado.BackColor = Color.LightSalmon;
                                        boton.BackColor = Color.LightSalmon;
                                        boton.Click += (s, e) =>
                                        {
                                            var form = new AsignacionViewRegister(i);
                                            form.ShowDialog();
                                            mostrarHabitaciones();
                                        };
                                        break;
                                    default:
                                        break;
                                }
                                panel.Controls.Add(boton);
                                this.panelCarrusel.Controls.Add(panel);
                                index++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay asignaciones por el momento", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
