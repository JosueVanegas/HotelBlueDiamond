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
            mostrarCarrucel();
        }
        private void mostrarRecepciones()
        {

        }
        private void mostrarCarrucel()
        {
            int itemWidth = 200;
            int itemHeight = 250;
            var habitaciones = new HabitacionesController(context).GetAllObjects();

            int index = 0;
            foreach (var i in habitaciones)
            {
                Panel productPanel = new Panel
                {
                    Width = itemWidth,
                    Height = itemHeight,
                    BorderStyle = BorderStyle.Fixed3D,
                    Left = index * itemWidth,
                };

                Label label = new Label
                {
                    Text = "Codigo:"+ i.Codigo + i.CategoriaHabitacion.Descripcion,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                productPanel.Controls.Add(label);

                Button verDetalles = new Button
                {
                    Text = "Ver detalles",
                    Dock = DockStyle.Bottom,
                    Size = new Size(itemWidth, 40),
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.White
                };
                verDetalles.Click += (s, e) => MessageBox.Show($"habitacion {i.Codigo} a sido seleccionada");
                productPanel.Controls.Add(verDetalles);
                Button Reservar = new Button
                {
                    Text = "Ver detalles",
                    Dock = DockStyle.Bottom,
                    Size = new Size(itemWidth, 40),
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.White
                };
                Reservar.Click += (s, e) => MessageBox.Show($"habitacion {i.Codigo} a sido seleccionada");
                productPanel.Controls.Add(Reservar);

                this.panelCarrusel.Controls.Add(productPanel);

                index++;
            }
        }

    }
}
