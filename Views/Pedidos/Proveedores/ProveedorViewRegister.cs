using Hotel.Controllers;
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

namespace Hotel.Views.Pedidos.Proveedores
{
    public partial class ProveedorViewRegister : Form
    {
        Proveedor proveedor;
        public ProveedorViewRegister(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            validarProveedor();
        }
        private void validarProveedor()
        {
            if (proveedor != null)
            {
                txtCargo.Text = proveedor.CargoContacto;
                txtCiudad.Text = proveedor.Ciudad;
                txtPais.Text = proveedor.Pais;
                txtEmpresa.Text = proveedor.NombreEmpresa;
                txtContacto.Text = proveedor.NombreContacto;
                txtDireccion.Text = proveedor.Direcccion;
                txtFax.Text = proveedor.Fax;
                txtTelefono.Text = proveedor.Telefono;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarCampos()
        {
            if (txtCargo.Text != string.Empty &&
            txtCiudad.Text != string.Empty &&
            txtContacto.Text != string.Empty &&
            txtDireccion.Text != string.Empty &&
            txtTelefono.Text != string.Empty &&
            txtEmpresa.Text != string.Empty &&
            txtFax.Text != string.Empty &&
            txtPais.Text != string.Empty)
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

                    using(var cont = new HotelContext())
                    {
                        var controller = new ProveedorController(cont);
                        if (proveedor != null)
                        {
                            Proveedor p = new Proveedor
                            {
                                ProveedorId = proveedor.ProveedorId,
                                NombreEmpresa = txtEmpresa.Text,
                                NombreContacto = txtContacto.Text,
                                CargoContacto = txtCargo.Text,
                                Ciudad = txtCiudad.Text,
                                Direcccion = txtDireccion.Text,
                                Fax = txtFax.Text,
                                Pais = txtPais.Text,
                                Telefono = txtTelefono.Text
                            };
                            controller.UpdateObjectAsync(p);
                            MessageBox.Show("Los datos del proveedor han sido actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Proveedor p = new Proveedor
                            {
                                NombreEmpresa = txtEmpresa.Text,
                                NombreContacto = txtContacto.Text,
                                CargoContacto = txtCargo.Text,
                                Ciudad = txtCiudad.Text,
                                Direcccion = txtDireccion.Text,
                                Fax = txtFax.Text,
                                Pais = txtPais.Text,
                                Telefono = txtTelefono.Text
                            };
                            controller.AddObjectAsync(p);
                            MessageBox.Show("Nuevo proveedor registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("LLene todos los campos para realizar esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
