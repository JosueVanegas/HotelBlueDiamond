using Hotel_Dorado_DesktopApp.View;
using Hotel_Dorado_DesktopApp.View.ClientesView;
using Hotel_Dorado_DesktopApp.Views.Home;
using Hotel_Dorado_DesktopApp.Views.Ayudas;
using Hotel_Dorado_DesktopApp.Views.GestionView;
using Hotel_Dorado_DesktopApp.Views.Login;
using Hotel_Dorado_DesktopApp.Views.Usuarios;

namespace Hotel_Dorado_DesktopApp
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