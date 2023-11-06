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

namespace Hotel_Dorado_DesktopApp.Views.Usuarios
{
    public partial class UsuariosViewRegister : Form
    {
        HotelDoradoContext context;
        Usuario usuario;
        public string mensaje = "";
        public UsuariosViewRegister(Usuario usuario)
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            this.usuario = usuario;
            validarUsuario();
            mostrarEmpleados();
            mostrarRoles();
        }
        private void validarUsuario()
        {
            if (usuario != null)
            {
                lblTitulo.Text = "Actualizar usuario";
                txtUsuario.Text = usuario.Usuario1;
                var cedulaBusqueda = usuario.Empleado.Cedula;
                foreach (var i in cbxEmpleados.Items)
                {
                    Empleado emp = i as Empleado;
                    if (emp != null && emp.Cedula == cedulaBusqueda)
                    {
                        cbxEmpleados.SelectedItem = emp;
                    }
                }
            }
        }
        private void mostrarEmpleados()
        {
            var controller = new EmpleadosController(context);
            var datos = controller.GetAllObjects();
            cbxEmpleados.DataSource = datos;
            cbxEmpleados.DisplayMember = "Cedula";
        }
        private void mostrarRoles()
        {
            var controller = new RolController(context);
            var datos = controller.GetAllObject();
            cbxRoles.DataSource = datos;
            cbxRoles.DisplayMember = "Descripcion";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos() == "")
                {
                    var controller = new UsuarioController(context);
                    var emp = cbxEmpleados.SelectedItem as Empleado;
                    var rol = cbxRoles.SelectedItem as Rol;
                    if (usuario != null)
                    {
                        Usuario user = new Usuario
                        {
                            UsuarioId = usuario.UsuarioId,
                            Usuario1 = txtUsuario.Text,
                            EmpleadoId = emp.EmpleadoId,
                            RolId = rol.RolId,
                            Clave = txtClave.Text,
                            FechaRegistro = DateTime.Now
                        };
                        controller.UpdateObject(user);
                        MessageBox.Show("Los datos del usuario han sido actualizados correctamente", "Actualización exitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Usuario user = new Usuario
                        {
                            Usuario1 = txtUsuario.Text,
                            EmpleadoId = emp.EmpleadoId,
                            RolId = rol.RolId,
                            Clave = txtClave.Text,
                            FechaRegistro = DateTime.Now
                        };
                        controller.AddObject(user);
                        MessageBox.Show("Nuevo usuario registrado correctamente", "Actualización exitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string validarCampos()
        {
            if (txtUsuario.Text != "" && txtClave.Text != "" && txtConfirmarClave.Text != "")
            {
                if (txtClave.Text == txtConfirmarClave.Text)
                {
                    mensaje = "";
                }
                else
                {
                    mensaje = "las contraseñas ingresadas no coinciden ";
                }
            }
            else
            {
                mensaje = "por favor llene todos los campos";
            }
            return mensaje;
        }
        private void cbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado emp = cbxEmpleados.SelectedItem as Empleado;
            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;

        }

        private void ckbVerClave_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerClave.Checked == true)
            {
                ckbVerClave.Text = "ocultar contraseña";
                txtClave.PasswordChar = '\0';
                txtConfirmarClave.PasswordChar = '\0';
            }
            else if (ckbVerClave.Checked == false)
            {
                ckbVerClave.Text = "mostrar contraseña";
                txtClave.PasswordChar = '*';
                txtConfirmarClave.PasswordChar = '*';
            }
        }
    }
}
