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

namespace Hotel_Dorado_DesktopApp.Views.EmpleadosAsignaciones.Personal
{
    public partial class CargosViewRegister : Form
    {
        Cargo cargo;
        public CargosViewRegister(Cargo cargo)
        {
            InitializeComponent();
            this.cargo = cargo;
        }
    }
}
