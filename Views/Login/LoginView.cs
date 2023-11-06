using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.Views.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.Login
{
    public partial class LoginView : Form
    {
        HotelDoradoContext context;
        public LoginView()
        {
            InitializeComponent();
            context = new HotelDoradoContext();
        }
        private bool validarEntradas()
        {
            if (txtUsuario.Text != "" && txtClave.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void login()
        {
            if (validarEntradas())
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    context = new HotelDoradoContext();
                    var controller = new UsuarioController(context);
                    bool permitir = controller.GetValue(txtUsuario.Text, txtClave.Text);
                    this.Cursor = Cursors.Default;

                    if (permitir)
                    {
                        var user = controller.GetObject(txtUsuario.Text);
                        HomeView form = new HomeView(user);
                        form.Show();
                        this.Hide();
                        form.FormClosing += frm_closing;
                        txtClave.Text = string.Empty;
                        txtUsuario.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("Porfavor llene todos los campos para poder realizar esta acción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        private void ckbVerClave_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerClave.Checked == true)
            {
                ckbVerClave.Text = "ocultar contraseña";
                txtClave.PasswordChar = '\0';
            }
            else if (ckbVerClave.Checked == false)
            {
                ckbVerClave.Text = "mostrar contraseña";
                txtClave.PasswordChar = '*';
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
