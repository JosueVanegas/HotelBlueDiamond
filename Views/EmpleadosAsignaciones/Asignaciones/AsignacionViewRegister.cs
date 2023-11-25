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

namespace Hotel.Views.EmpleadosAsignaciones.Asignaciones
{
    public partial class AsignacionViewRegister : Form
    {
        private Habitacion habitacion;
        private Asignacion asignacion;
        public AsignacionViewRegister(Habitacion habitacion)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            encontrarAsignacion();
            mostrarAsignaciones();
            mostrarEmpleados();
            mostrarDatos();
        }
        private void encontrarAsignacion()
        {
            var controller = new AsignacionController(new HotelContext());
            var asignacion = controller.GetObjectByHabId(habitacion.HabitacionId);
            if (asignacion != null && asignacion.Estado == false)
            {
                this.asignacion = asignacion;
            }
        }
        private async void mostrarEmpleados()
        {
            var controller = new EmpleadosController(new HotelContext());
            cbxEmpleado.DataSource = await controller.GetAllObjects();
            cbxEmpleado.DisplayMember = "Cedula";
        }
        private void mostrarAsignaciones()
        {
            var controller = new AsignacionController(new HotelContext());
            foreach (EstadoHabitacion i in controller.GetStatesH())
            {
                if (i.EstadoId != 1 && i.EstadoId != 2)
                {
                    cbxAsignaciones.Items.Add(i);
                    cbxAsignaciones.DisplayMember = "Descripcion";
                }
            }
            cbxAsignaciones.SelectedIndex = 0;

        }
        private void mostrarDatos()
        {
            if (this.asignacion != null)
            {
                var estado = asignacion.Habitacion.EstadoId;
                cbxAsignaciones.Enabled = false;
                cbxEmpleado.Enabled = false;
                foreach (var i in cbxEmpleado.Items)
                {
                    Empleado emp = i as Empleado;
                    if (emp != null && emp.Cedula == asignacion.Empleado.Cedula)
                    {
                        cbxEmpleado.SelectedItem = emp;
                    }
                }
                foreach (var i in cbxAsignaciones.Items)
                {
                    EstadoHabitacion eh = i as EstadoHabitacion;
                    if (eh != null && eh.EstadoId == asignacion.Habitacion.EstadoId)
                    {
                        cbxEmpleado.SelectedItem = eh;
                    }
                }
                if (estado == 3)
                {
                    label1.Text = "Finalizar limpieza";
                }
                else if (estado == 4)
                {
                    label1.Text = "Finalizar mantenimiento";
                }

                txtCategoria.Text = asignacion.Habitacion.CategoriaHabitacion.Descripcion;
                txtNumero.Text = asignacion.Habitacion.Codigo;
                txtPiso.Text = asignacion.Habitacion.Piso.Descripcion;
                txtDetallesAsignacion.Text = asignacion.Descripcion;
                txtBonificación.Text = asignacion.ComisionGenerada.ToString();
                btnAgregar.Text = "Finalizar tarea";
                txtBonificación.Enabled = false;
                txtDetallesAsignacion.Enabled = false;
                dtpEntrada.Text = asignacion.FechaAsignacion.ToString();
            }
            else
            {
                txtCategoria.Text = habitacion.CategoriaHabitacion.Descripcion;
                txtNumero.Text = habitacion.Codigo;
                txtPiso.Text = habitacion.Piso.Descripcion;
            }

        }
        private bool validarEntradas()
        {
            if (txtDetallesAsignacion.Text != "")
                return true;
            else
                return false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarEntradas())
                {
                    var controller = new AsignacionController(new HotelContext());
                    var item = cbxAsignaciones.SelectedItem as EstadoHabitacion;
                    var emp = cbxEmpleado.SelectedItem as Empleado;
                    if (asignacion != null)
                    {
                        asignacion.FechaConclusion = DateTime.Now;
                        asignacion.Estado = true;
                        controller.UpdateObject(asignacion);
                        controller.ChangeHabEstate(habitacion.HabitacionId,1);
                        MessageBox.Show("Asignación concluida exitosamente", "Finalización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var nuevaAsignacion = new Asignacion
                        {
                            Descripcion = txtDetallesAsignacion.Text,
                            ComisionGenerada = Convert.ToDecimal(txtBonificación.Text),
                            EmpleadoId = emp.EmpleadoId,
                            HabitacionId = habitacion.HabitacionId,
                            FechaAsignacion = DateTime.Now,
                            Estado = false,
                            TipoAsignacion = item.Descripcion
                        };
                        controller.AddObject(nuevaAsignacion);
                        controller.ChangeHabEstate(habitacion.HabitacionId, item.EstadoId);
                        MessageBox.Show("Nueva asignacion registrada", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese los detalles la asignación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (e.KeyChar == '.' && textBox.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }
            if (textBox.Text.Length >= 10 || (textBox.Text.Contains(".") && textBox.Text.Split('.')[1].Length >= 2) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emp = cbxEmpleado.SelectedItem as Empleado;
            if (emp != null)
            {
                txtNombreEmpleado.Text = emp.Nombre + " " + emp.Apellido;
            }
        }
    }
}
