using Hotel.Controllers;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel.Views.Home
{
    public partial class DashBoardView : Form
    {
        HotelContext context;
        DashBoardController controller;
        public DashBoardView()
        {
            InitializeComponent();
            context = new HotelContext();
            controller = new DashBoardController(context);
            llenarDashboard();
            //cargarGrafica();
        }
        private async void llenarDashboard()
        {
            lblTotal.Text = (await controller.HabitacionesTotales()).ToString();
            lblDisponibles.Text = (await controller.HabitacionesDisponibles(1)).ToString();
            lblOcupadas.Text = (await controller.HabitacionesDisponibles(2)).ToString();
            lblLimpieza.Text = (await controller.HabitacionesDisponibles(3)).ToString();
            lblMantenimiento.Text = (await controller.HabitacionesDisponibles(4)).ToString();
            lblCantidadHuespedes.Text = (await controller.CantidadHuespedes()).ToString();
        }

        private async void cargarGrafica()
        {
            var datos = await controller.GraphicDataAsync();

            if (datos != null)
            {
                foreach (var item in datos)
                {
                    grapTopProductos.Series["Series1"].Points.AddXY(item.Key, item.Value);
                }
                grapTopProductos.Visible = true;
            }
            else
            {
                grapTopProductos.Visible = false;
            }
        }
    }
}
