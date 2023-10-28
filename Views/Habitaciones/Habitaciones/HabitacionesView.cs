using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.Views.Habitaciones.Habitaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.Habitaciones
{
    public partial class HabitacionesView : Form
    {
        HotelDoradoContext context;
        HabitacionesController controller;
        public HabitacionesView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new HabitacionesController(context);
            mostrarHabitaciones();
        }
        private void mostrarHabitaciones()
        {
            var lista = controller.GetAllObjects();
            tbHabitaciones.Rows.Clear();
            foreach (var i in lista)
            {
                tbHabitaciones.Rows.Add(i.HabitacionId, i.Codigo, i.Piso.Descripcion, i.CategoriaHabitacion.Descripcion, i.PrecioPh);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            HabitacionesViewRegister form = new HabitacionesViewRegister(null);
            mostrarHabitaciones();
        }
    }
    //estados posibles values('Disponible'),('No disponible'),('En Limpieza'),('En Mantenimiento')
}
