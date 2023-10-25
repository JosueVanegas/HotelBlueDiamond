using Hotel_Dorado_DesktopApp.View;
using Hotel_Dorado_DesktopApp.View.ClientesView;

namespace Hotel_Dorado_DesktopApp
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeView());
        }
    }
}