using Hotel.View;
using Hotel.View.ClientesView;
using Hotel.Views.Home;
using Hotel.Views.Ayudas;
using Hotel.Views.GestionView;
using Hotel.Views.Login;
using Hotel.Views.Usuarios;

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