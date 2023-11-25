using Hotel.View;
using Hotel.View.ClientesView;
using Hotel.Views.Home;
using Hotel.Views.Ayudas;
using Hotel.Views.GestionView;
using Hotel.Views.Login;
using Hotel.Views.Usuarios;
using Hotel.Views.Pedidos.Compras;
using Hotel.Views.EmpleadosAsignaciones.Asignaciones;

namespace Hotel
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeView(null));
        }
    }
}