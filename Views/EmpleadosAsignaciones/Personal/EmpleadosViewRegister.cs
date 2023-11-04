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

namespace Hotel_Dorado_DesktopApp.Views.EmpleadosAsignaciones.Personal
{
    public partial class EmpleadosViewRegister : Form
    {
        Empleado empleado;
        public EmpleadosViewRegister(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            validarDatePicker();
            mostrarCargos();
            validarObjeto();
        }
        private void validarDatePicker()
        {
            dtNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            dtNacimiento.MinDate = DateTime.Now.AddYears(-67);
        }
        private void mostrarCargos()
        {
            var context = new HotelDoradoContext();
            cbxCargo.DataSource = new CargosController(context).GetAllObject();
            cbxCargo.DisplayMember = "Descripcion";
        }
        private void validarObjeto()
        {
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtCedula.Text = empleado.Cedula;
                txtCorreo.Text = empleado.Correo;
                txtTelefono.Text = empleado.Telefono;
                int idCargo = empleado.Cargo.CargoId;
                foreach (var item in cbxCargo.Items)
                {
                    Cargo ch = item as Cargo;
                    if (ch != null && ch.CargoId == idCargo)
                    {
                        cbxCargo.SelectedItem = ch;
                        break;
                    }
                }
                dtNacimiento.Value = (DateTime)empleado.Nacimiento;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new HotelDoradoContext();
                var controller = new EmpleadosController(context);
                if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "")
                {
                    var cargo = (Cargo)cbxCargo.SelectedItem;
                    if (empleado != null)
                    {
                        Empleado emp = new Empleado
                        {
                            EmpleadoId = empleado.EmpleadoId,
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            Cedula = txtCedula.Text,
                            Telefono = txtTelefono.Text,
                            Correo = txtCorreo.Text,
                            Cargo = cargo,
                            Nacimiento = dtNacimiento.Value,
                            FechaRegistro = DateTime.Now,
                            Activo = true
                        };
                        controller.UpdateObject(emp);
                        MessageBox.Show("Los datos del empleado han sido actualizados","Actualización exitosa",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Empleado emp = new Empleado
                        {
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            Cedula = txtCedula.Text,
                            Telefono = txtTelefono.Text,
                            Correo = txtCorreo.Text,
                            Cargo = cargo,
                            Nacimiento = dtNacimiento.Value,
                            FechaRegistro = DateTime.Now,
                            Activo = true
                        };
                        controller.UpdateObject(emp);
                        MessageBox.Show("Nuevo empleado registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos para poder realizar esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
