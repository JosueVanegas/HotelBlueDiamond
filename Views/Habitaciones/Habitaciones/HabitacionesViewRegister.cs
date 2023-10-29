using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.Views.Habitaciones.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.Habitaciones.Habitaciones
{
    public partial class HabitacionesViewRegister : Form
    {
        HotelDoradoContext context;
        HabitacionesController controller;
        Habitacion habitacion;
        public HabitacionesViewRegister(Habitacion habitacion)
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new HabitacionesController(context);
            this.habitacion = habitacion;
            cargarComboBox();
            
        }
        private void validarHabitacion()
        {
            mostrarCategorias();
            mostrarPisos();
            if (this.habitacion != null)
            {
                txtId.Text = habitacion.HabitacionId.ToString();
                txtDetalles.Text = habitacion.Detalles.ToString();
                txtNumero.Text = habitacion.Codigo.ToString();
                txtTarifa.Text = habitacion.PrecioPh.ToString();
                txtExtras.Text = habitacion.Extras.ToString();
                lblTitulo.Text = "Actualizar Habitación";
                int categoriaIdBuscar = habitacion.CategoriaHabitacion.CategoriaHabitacionId;
                int pisoIdBuscar = habitacion.Piso.PisoId;
                
                
                foreach (var item in cbxCategorias.Items)
                {
                    CategoriaHabitacion ch = item as CategoriaHabitacion;
                    if (ch != null && ch.CategoriaHabitacionId == categoriaIdBuscar)
                    {
                        cbxCategorias.SelectedItem = ch;
                        break;
                    }
                }
                foreach (var item in cbxPiso.Items)
                {
                    Piso ch = item as Piso;
                    if (ch != null && ch.PisoId == pisoIdBuscar)
                    {
                        cbxPiso.SelectedItem = ch;
                        break;
                    }
                }
            }
        }
        private void cargarComboBox()
        {
            var existeCategoria = controller.GetCategoriaHabitacions();
            if (existeCategoria != null)
            {
                validarHabitacion();
                this.ShowDialog();
            }
            else
            {
                if (MessageBox.Show(@"Para poder registrar una habitación es necesario que exista al menos una categoria,Desea registrar una categoria de habitación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    CategoriaHabitacionViewRegister form = new CategoriaHabitacionViewRegister(null);
                    form.ShowDialog();
                }
                this.Dispose();
            }
        }
        private void mostrarPisos()
        {
            cbxPiso.DataSource = controller.GetPisoHabitacions();
            cbxPiso.DisplayMember = "Descripcion";

        }
        private void mostrarCategorias()
        {
            cbxCategorias.DataSource = controller.GetCategoriaHabitacions();
            cbxCategorias.DisplayMember = "Descripcion";
        }
        private bool validarCampos()
        {
            if (txtDetalles.Text != "" && txtExtras.Text != "" && txtNumero.Text != "" && txtTarifa.Text != "")
                return true;
            else
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    if (habitacion == null)
                    {
                        var piso = (Piso)cbxPiso.SelectedItem;
                        var categoria = (CategoriaHabitacion)cbxCategorias.SelectedItem;
                        Habitacion h = new Habitacion
                        {
                            Detalles = txtDetalles.Text,
                            Extras = txtExtras.Text,
                            EstadoId = 1,
                            PrecioPh = Convert.ToDecimal(txtTarifa.Text),
                            Codigo = txtNumero.Text,
                            PisoId = piso.PisoId,
                            CategoriaHabitacionId = categoria.CategoriaHabitacionId
                        };
                        controller.AddObject(h);
                        MessageBox.Show("Nueva habitación registrada correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var piso = (Piso)cbxPiso.SelectedItem;
                        var categoria = (CategoriaHabitacion)cbxCategorias.SelectedItem;
                        Habitacion h = new Habitacion
                        {
                            HabitacionId = habitacion.HabitacionId,
                            Detalles = txtDetalles.Text,
                            Extras = txtExtras.Text,
                            EstadoId = habitacion.EstadoId,
                            PrecioPh = Convert.ToDecimal(txtTarifa.Text),
                            Codigo = txtNumero.Text,
                            PisoId = piso.PisoId,
                            CategoriaHabitacionId = categoria.CategoriaHabitacionId
                        };
                        controller.UpdateObject(h);
                        MessageBox.Show("Los datos de la  habitación han sido actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados para poder registrar la habitación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
