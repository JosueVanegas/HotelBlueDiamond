using Hotel.Controller;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.View.ClientesView
{
    public partial class ClienteViewRegister : Form
    {
        HotelContext context;
        ClienteController controller;
        Cliente cliente;
        bool ClienteNuevo = true;
        public ClienteViewRegister(Cliente cliente)
        {
            InitializeComponent();
            context = new HotelContext();
            controller = new ClienteController(context);
            this.cliente = cliente;
            validarObjeto();
            this.ShowDialog();
        }
        private void validarObjeto()
        {
            if (cliente != null)
            {
                ClienteNuevo = false;
                lblTitulo.Text = "Actualizar Datos";
                txtCedula.Text = cliente.Cedula;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtTelefono.Text = cliente.Telefono;
                txtCorreo.Text = cliente.Email;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }
        private bool validarCampos()
        {
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != ""
                        && txtTelefono.Text != "" && txtCorreo.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    if (ClienteNuevo == true)
                    {
                        Cliente c = new Cliente
                        {
                            Cedula = txtCedula.Text,
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            Telefono = txtTelefono.Text,
                            Email = txtCorreo.Text
                        };
                        controller.AddObject(c);
                        limpiarCampos();
                        MessageBox.Show("Nuevo Cliente Guardado Registrado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Cliente c = new Cliente
                        {
                            ClienteId = cliente.ClienteId,
                            Cedula = txtCedula.Text,
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            Telefono = txtTelefono.Text,
                            Email = txtCorreo.Text
                        };
                        controller.UpdateObject(c);
                        limpiarCampos();
                        MessageBox.Show("Datos del cliente actualizados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese valores en todos los campos para guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }

        }
    }
}
