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
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel_Dorado_DesktopApp.Views.Home
{
    public partial class DashBoardView : Form
    {
        HotelDoradoContext context;
        DashBoardController controller;
        public DashBoardView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new DashBoardController(context);
            llenarDashboard();
            cargarGrafica();
        }
        private void llenarDashboard()
        {
            lblTotal.Text = controller.HabitacionesTotales().ToString();
            lblDisponibles.Text = controller.HabitacionesDisponibles(1).ToString();
            lblOcupadas.Text = controller.HabitacionesDisponibles(2).ToString();
            lblLimpieza.Text = controller.HabitacionesDisponibles(3).ToString();
            lblMantenimiento.Text = controller.HabitacionesDisponibles(4).ToString();
            lblCantidadHuespedes.Text = controller.CantidadHuespedes().ToString();
        }
        private void cargarGrafica()
        {
            var datos = controller.GraphicData();

           if(datos.Count == 0 )
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
