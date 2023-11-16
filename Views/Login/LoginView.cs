using Hotel.Controllers;
using Hotel.Models;
using Hotel.Views.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Login
{
    public partial class LoginView : Form
    {
        HotelContext context;
        public LoginView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
        private  void login()
        {
            try
            {
                if (validarEntradas())
                {
                    context = new HotelContext();
                    var controller = new UsuarioController(context);
                    this.Cursor = Cursors.WaitCursor;
                    bool permitir = controller.GetValue(txtUsuario.Text, txtClave.Text);
                    if (permitir)
                    {
                        var user =  controller.GetObjectByUser(txtUsuario.Text);
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
                else
                {
                    MessageBox.Show("Porfavor llene todos los campos para poder realizar esta acción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

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
            Application.Exit();
        }
    }
}
