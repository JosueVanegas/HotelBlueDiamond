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

namespace Hotel_Dorado_DesktopApp.Views.HomeView
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
        }
        private void llenarDashboard()
        {
            lblCantidadHabitaciones.Text = controller.Habitaciones().ToString();
        }
    }
}
